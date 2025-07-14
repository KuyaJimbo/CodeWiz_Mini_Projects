import random

# Get the player's Pokémon name
pokemon_name = input("Enter the name of the Pokemon: ")

# Set AI Pokémon name
ai_name = "Pikachu"

# Initialize health
pokemon_health = 100
ai_health = 100

# Main loop
while pokemon_health > 0 and ai_health > 0:
    # TODO: Print your Pokemon's Name and Health
    # TODO: Print the AI Pokemon's Name and Health
    print(f"{pokemon_name} Health: {}")
    print(f"{} Health: {}")

    # Ask player for action
    action = input(f"Choose an action for {pokemon_name}: Attack (1), Special Attack (2): ")

    if action == '1':
        # TODO: Add regular attack damage logic here
        # damage = ?
        # ai_health -= ?
        print(f"{pokemon_name} used Attack and dealt {} damage!")

    elif action == '2':
        # TODO: Add special attack damage logic here
        # damage = ?
        # ai_health -= ?
        print(f"{pokemon_name} used Special Attack and dealt {} damage!")

    else:
        print("Invalid action. Please choose 1 or 2.")
        continue

    # Check if AI is defeated
    if ai_health <= 0:
        print(f"{} has been defeated! {} wins!")
        break

    # AI's Turn
    ai_action = random.choice(['1', '2'])

    if ai_action == '1':
        # TODO: Add AI regular attack logic here
        # damage = ?
        # pokemon_health -= ?
        print(f"{} used Attack and dealt {} damage!")

    elif ai_action == '2':
        # TODO: Add AI special attack logic here
        # damage = ?
        # pokemon_health -= ?
        print(f"{} used Special Attack and dealt {} damage!")

# Result
# TODO: If your Pokemon's health is less than or equal to 0, your pokemon was defeated
# TODO: Otherwise, your pokemon won!
