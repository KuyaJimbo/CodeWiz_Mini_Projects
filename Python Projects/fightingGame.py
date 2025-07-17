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
print(f"{Enemy_Name} has appeared with {Enemy_Health} Health!")

# -------------------------------------------------------------
while Player_Health > 0 and Enemy_Health > 0:
    print("Player has {Player_Health} HP.")
    print("Enemy has {Enemy_Health} HP.")

    Enemy_choice = random.randint(1, 3)
    Player_choice = input("Choose your Move: Attack (1), Counter (2), Heal (3)")
    
    # Player Attacked (1)?
    if Player_choice == 1:
        # Enemy Countered (2)? Player loses 15 HP
        if Enemy_choice == 2:
            Player_Health -= 15
        # Enemy did not counter? Enemy loses 10 HP
        else:
            Enemy_Health -= 10
    
    # Player Healed (3)?
    if Player_choice == 3:
        Player_Health += 10
    

    # Enemy Attacked (1)?
    if Enemy_choice == 1:
        # Player Countered (2)? Enemy loses 15 HP
        if Enemy_choice == 2:
            Enemy_Health -= 15
        # Player did not counter? Player loses 10 HP
        else:
            Enemy_Health -= 10
    
    # Enemy Healed (3)?
    if Enemy_choice == 3:
        Enemy_Health += 10


# Determine the Winner: who has more health?
if Player_Health > Enemy_Health:
    print(f"{Player_Name}, you are the winner!")
else:
    print(f"Sorry {Player_Name}, you lost!")