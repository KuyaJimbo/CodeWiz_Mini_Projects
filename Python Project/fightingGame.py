import random

# Greet the Player!
Player_Name = input("What's your name, Player? ")
Player_Health = 100
print(f"Welcome {Player_Name}! You have {Player_Health} Health!")

# Display the Rules!
print("Attacks do 10 damage.")
print("Counters do 5 damage and deflects any attack damage from the opponent.")
print("If both Players Counter each other, No damage is given.")
print("Healing recovers 10 HP.")

# Set up choices for your Enemy
Enemy_Names = ["Zombie", "Skeleton"]
Enemy_Moves = ["Attack", "Counter", "Heal"]

# Create your Enemy
Enemy_Name = random.choice(Enemy_Names)
Enemy_Health = random.randint(100,200)

# Print the Information about the Enemy_Health


# -------------------------------------------------------------
while Player_Health > 0 and Enemy_Health > 0:
    # Display current health of the Player and Enemy
    
    # Get the Enemy's random choice
    Enemy_choice = random.

    # Get the Player's choice
    Player_choice = int(input("Choose your Move: Attack (1), Counter (2), Heal (3)"))
    
    # Player Attacked (1)?
    if Player_choice == 1:
        # Enemy Countered (2)? Player loses 15 HP
        if Enemy_choice == 2:
            Player_Health -= 15
            print(f"{Enemy_Name} countered your attack! You lose 15 HP.")
        # Enemy did not counter? Enemy loses 10 HP
        else:
            Enemy_Health -= 10
            print(f"You attacked {Enemy_Name}! It loses 10 HP.")
    
    # Player Healed (3)?
    if Player_choice == 3:
        Player_Health += 10
        print(f"You healed yourself! You gain 10 HP.")

    # Enemy Attacked (1)?
    
        # Player Countered (2)? Enemy loses 15 HP
    
        # Player did not counter? Player loses 10 HP
    
    # Enemy Healed (3)?
    


# Determine the Winner: who has more health?
if Player_Health > Enemy_Health:
    print(f"")
else:
    print(f"")