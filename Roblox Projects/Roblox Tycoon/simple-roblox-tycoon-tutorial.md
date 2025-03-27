# SIMPLE ROBLOX TYCOON TUTORIAL
## For 2-Player Games

---

## PART 1: GAME SETUP
### Creating the Base

1. Create a new Roblox place
2. Delete the default Baseplate
3. Create two flat platforms (one for each player's tycoon)
   - Make each platform 50x50 studs
   - Set one at position (100, 0, 0) and the other at (-100, 0, 0)
   - Name them "Tycoon1" and "Tycoon2"
4. Create a spawn location for each platform

### Setting Up Folders

1. In each tycoon model (Tycoon1 and Tycoon2), create these folders:
   - MainItems
   - BoughtItems
   - Buttons
   - Scripts
   - Values

---

## PART 2: LEADERSTATS
### Setting Up Player Cash

1. Create a new script in ServerScriptService
2. Name it "LeaderStats"
3. Add this code:

```lua
-- LeaderStats Script
game.Players.PlayerAdded:Connect(function(player)
    -- Create stats folder
    local stats = Instance.new("Folder")
    stats.Name = "leaderstats"
    stats.Parent = player
    
    -- Create cash value
    local cash = Instance.new("IntValue")
    cash.Name = "Cash"
    cash.Value = 10  -- Starting cash
    cash.Parent = stats
    
    print(player.Name .. " joined with $10")
end)
```

---

## PART 3: TYCOON OWNERSHIP
### Creating Owner Doors

1. For each tycoon, create an "OwnerDoor" in its MainItems folder:
   - Create a part sized 6x8x1
   - Name it "OwnerDoor"
   - Position it at the entrance of each tycoon
   - Add a SurfaceGui with a TextLabel that says "Click to Claim"

2. Create an OwnerValue in each tycoon's Values folder:
   - Add a new ObjectValue
   - Name it "Owner"

3. Add an OwnerScript to each tycoon's Scripts folder:

```lua
-- OwnerScript
local tycoon = script.Parent.Parent
local door = tycoon.MainItems.OwnerDoor
local ownerValue = tycoon.Values.Owner

-- Update door text based on ownership
local function updateDoorText()
    local owner = ownerValue.Value
    if owner then
        door.SurfaceGui.TextLabel.Text = "Owned by " .. owner.Name
        door.Transparency = 0.5
    else
        door.SurfaceGui.TextLabel.Text = "Click to Claim"
        door.Transparency = 0
    end
end

-- Handle door clicks
door.ClickDetector.MouseClick:Connect(function(player)
    if not ownerValue.Value then
        ownerValue.Value = player
        updateDoorText()
        print(player.Name .. " claimed " .. tycoon.Name)
    end
end)

-- Handle player leaving
game.Players.PlayerRemoving:Connect(function(player)
    if ownerValue.Value == player then
        ownerValue.Value = nil
        updateDoorText()
        print(tycoon.Name .. " is now available")
    end
end)

-- Initial setup
updateDoorText()
```

4. Add a ClickDetector to each OwnerDoor

---

## PART 4: CASH DISPLAY
### Creating a Cash GUI

1. Create a ScreenGui in StarterGui
2. Name it "CashDisplay"
3. Add a TextLabel positioned at the top of the screen
4. Add this LocalScript in the CashDisplay:

```lua
-- CashDisplay LocalScript
local player = game.Players.LocalPlayer
local cashValue = player:WaitForChild("leaderstats"):WaitForChild("Cash")
local display = script.Parent.TextLabel

-- Update the display when cash changes
local function updateDisplay()
    display.Text = "Cash: $" .. cashValue.Value
end

-- Connect to value changes
cashValue.Changed:Connect(updateDisplay)

-- Initial update
updateDisplay()
```

---

## PART 5: BASIC DROPPER
### Creating the Money Generator

1. For each tycoon, create a dropper in its MainItems folder:
   - Create a model named "BasicDropper"
   - Add parts to make it look like a machine
   - Add a part named "SpawnPart" where money will spawn

2. Add a DropperScript to each BasicDropper:

```lua
-- DropperScript
local tycoon = script.Parent.Parent.Parent
local spawnPart = script.Parent.SpawnPart
local ownerValue = tycoon.Values.Owner

-- Create a folder for dropped parts if it doesn't exist
local droppedParts = tycoon:FindFirstChild("DroppedParts")
if not droppedParts then
    droppedParts = Instance.new("Folder")
    droppedParts.Name = "DroppedParts"
    droppedParts.Parent = tycoon
end

-- Only produce money if tycoon is owned
while true do
    wait(2)  -- Drop every 2 seconds
    
    if ownerValue.Value then
        -- Create money part
        local money = Instance.new("Part")
        money.Size = Vector3.new(1, 1, 1)
        money.Position = spawnPart.Position
        money.Anchored = false
        money.CanCollide = true
        money.BrickColor = BrickColor.new("Bright yellow")
        money.Material = Enum.Material.Neon
        
        -- Add value to the money
        local value = Instance.new("IntValue")
        value.Name = "Value"
        value.Value = 1  -- $1 per part
        value.Parent = money
        
        money.Parent = droppedParts
    end
end
```

---

## PART 6: COLLECTOR
### Creating the Money Collector

1. For each tycoon, create a collector in its MainItems folder:
   - Create a part sized 6x1x6
   - Position it at the end of the tycoon
   - Name it "Collector"
   - Add a glowing material or color

2. Add a CollectorScript to each Collector:

```lua
-- CollectorScript
local tycoon = script.Parent.Parent.Parent
local ownerValue = tycoon.Values.Owner

-- When a part touches the collector
script.Parent.Touched:Connect(function(part)
    -- Check if it's a money part
    local value = part:FindFirstChild("Value")
    if value then
        -- Find the owner
        local owner = ownerValue.Value
        if owner then
            -- Add money to the player
            local cash = owner.leaderstats.Cash
            cash.Value = cash.Value + value.Value
            
            -- Destroy the money part
            part:Destroy()
        end
    end
end)
```

---

## PART 7: CONVEYOR BELT
### Moving Money to the Collector

1. For each tycoon, create a conveyor in its MainItems folder:
   - Create a part sized 4x1x20
   - Position it between the dropper and collector
   - Name it "Conveyor"

2. Add a ConveyorScript to each Conveyor:

```lua
-- ConveyorScript
local conveyor = script.Parent

-- Set conveyor properties
conveyor.Anchored = true
conveyor.BrickColor = BrickColor.new("Dark grey")
conveyor.Material = Enum.Material.Metal

-- Create conveyor force
local bodyVelocity = Instance.new("BodyVelocity")
bodyVelocity.MaxForce = Vector3.new(1000, 0, 1000)
bodyVelocity.P = 1000
bodyVelocity.Velocity = conveyor.CFrame.LookVector * 8  -- Speed and direction

-- Apply force to parts that touch the conveyor
conveyor.Touched:Connect(function(part)
    -- Ignore parts that aren't money
    if not part:FindFirstChild("Value") then return end
    
    -- Create a clone of the body velocity for this part
    local velocity = bodyVelocity:Clone()
    velocity.Parent = part
    
    -- Remove the force after the part leaves
    conveyor.TouchEnded:Connect(function(touchedPart)
        if touchedPart == part and velocity then
            velocity:Destroy()
        end
    end)
end)
```

---

## PART 8: UPGRADE BUTTONS
### Creating Purchasable Upgrades

1. For each tycoon, create a button in its Buttons folder:
   - Create a part sized 4x1x4
   - Name it "DropperUpgrade"
   - Position it near the dropper
   - Add a ClickDetector

2. Add a ButtonScript to each button:

```lua
-- ButtonScript
local tycoon = script.Parent.Parent.Parent
local ownerValue = tycoon.Values.Owner
local button = script.Parent

-- Add SurfaceGui to display info
local gui = Instance.new("SurfaceGui")
gui.Parent = button
gui.Face = Enum.NormalId.Top

local frame = Instance.new("Frame")
frame.Size = UDim2.new(1, 0, 1, 0)
frame.BackgroundColor3 = Color3.new(0, 0.5, 1)
frame.Parent = gui

local nameLabel = Instance.new("TextLabel")
nameLabel.Size = UDim2.new(1, 0, 0.5, 0)
nameLabel.BackgroundTransparency = 1
nameLabel.Text = "Faster Dropper"
nameLabel.TextScaled = true
nameLabel.Parent = frame

local priceLabel = Instance.new("TextLabel")
priceLabel.Size = UDim2.new(1, 0, 0.5, 0)
priceLabel.Position = UDim2.new(0, 0, 0.5, 0)
priceLabel.BackgroundTransparency = 1
priceLabel.Text = "$25"
priceLabel.TextScaled = true
priceLabel.Parent = frame

-- Track if upgrade is purchased
local purchased = false

-- Handle button clicks
button.ClickDetector.MouseClick:Connect(function(player)
    -- Check if player is owner
    if player ~= ownerValue.Value then return end
    
    -- Check if already purchased
    if purchased then
        -- Notify player it's already purchased
        game.ReplicatedStorage.Remotes.Notify:FireClient(player, "Already purchased!")
        return
    end
    
    -- Check if player has enough cash
    if player.leaderstats.Cash.Value >= 25 then
        -- Subtract cash
        player.leaderstats.Cash.Value = player.leaderstats.Cash.Value - 25
        
        -- Mark as purchased
        purchased = true
        frame.BackgroundColor3 = Color3.new(0, 0.7, 0)
        nameLabel.Text = "PURCHASED"
        priceLabel.Text = ""
        
        -- Upgrade the dropper
        local dropper = tycoon.MainItems.BasicDropper
        local dropperScript = dropper:FindFirstChild("DropperScript")
        
        if dropperScript then
            -- Replace with upgraded script that produces faster and more valuable money
            dropperScript.Disabled = true
            
            local newScript = dropperScript:Clone()
            newScript.Parent = dropper
            
            -- Modify the script to be faster (wait 1 second instead of 2)
            -- and more valuable ($2 instead of $1)
            local source = newScript.Source
            source = source:gsub("wait%(2%)", "wait(1)")
            source = source:gsub("value.Value = 1", "value.Value = 2")
            newScript.Source = source
            
            dropperScript:Destroy()
            newScript.Disabled = false
        end
    else
        -- Notify player they don't have enough cash
        game.ReplicatedStorage.Remotes.Notify:FireClient(player, "Not enough cash!")
    end
end)
```

3. Create a RemoteEvent for notifications:
   - Add a Folder named "Remotes" in ReplicatedStorage
   - Add a RemoteEvent named "Notify" inside it

4. Create a NotificationHandler in StarterGui:

```lua
-- NotificationHandler
local remote = game.ReplicatedStorage.Remotes.Notify

-- Handle notifications
remote.OnClientEvent:Connect(function(message)
    -- Create a notification
    local notification = Instance.new("TextLabel")
    notification.Size = UDim2.new(0, 200, 0, 50)
    notification.Position = UDim2.new(0.5, -100, 0.8, 0)
    notification.BackgroundColor3 = Color3.new(0, 0, 0)
    notification.BackgroundTransparency = 0.5
    notification.TextColor3 = Color3.new(1, 1, 1)
    notification.Text = message
    notification.TextScaled = true
    notification.Parent = script.Parent
    
    -- Remove after 3 seconds
    game.Debris:AddItem(notification, 3)
end)
```

---

## PART 9: GAME LOOP
### Testing Your Tycoon

1. Test your game to make sure all components work:
   - Players can claim a tycoon
   - Droppers generate money
   - Conveyor moves money to collector
   - Collector adds money to player's cash
   - Players can purchase upgrades
   - Only 2 players can claim tycoons at once

2. Add final touches:
   - Create a spawn location in the middle
   - Add barriers to prevent players from entering unclaimed tycoons
   - Add lighting effects to make droppers and collectors more visible

---

## TROUBLESHOOTING TIPS

- **Money not spawning?**
  Check if the tycoon has an owner and the dropper script is enabled.

- **Conveyor not working?**
  Verify the direction vector in the ConveyorScript.

- **Cash not increasing?**
  Ensure the collector is detecting money parts and the Value object is correctly named.

- **Upgrades not applying?**
  Check if the script replacement in ButtonScript is working properly.

- **Owner door not responding?**
  Make sure the ClickDetector is added and the OwnerScript references are correct.
