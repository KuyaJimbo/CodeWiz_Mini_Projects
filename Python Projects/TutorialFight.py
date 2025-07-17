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
    print(f"{Player_Name} has {Player_Health} HP.")
    print(f"{Enemy_Name} has {Enemy_Health} HP.")

    Enemy_choice = random.randint(1, 3)
    Player_choice = input("Choose your Move: Attack (1), Counter (2), Heal (3)")
    
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
    if Enemy_choice == 1:
        # Player Countered (2)? Enemy loses 15 HP
        if Enemy_choice == 2:
            Enemy_Health -= 15
            print(f"{Enemy_Name} attacked, but you countered! {Enemy_Name} loses 15 HP.")
        # Player did not counter? Player loses 10 HP
        else:
            Enemy_Health -= 10
            print(f"{Enemy_Name} attacked you! You lose 10 HP.")
    
    # Enemy Healed (3)?
    if Enemy_choice == 3:
        Enemy_Health += 10
        print(f"{Enemy_Name} healed itself! It gains 10 HP.")


# Determine the Winner: who has more health?
if Player_Health > Enemy_Health:
    print(f"{Player_Name}, you are the winner!")
else:
    print(f"Sorry {Player_Name}, you lost!")