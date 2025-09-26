import random

# Get the name of the player's Pokemon from user input
pokemon_name = input("Enter the name of the Pokemon: ")

# Set the AI opponent's name
ai_name = "Pikachu"

# Initialize health values for both Pokémon
pokemon_health = 100
ai_health = 100

# Main battle loop: runs until one Pokémon's health reaches 0 or below
while pokemon_health > 0 and ai_health > 0:
    print(f"\n{pokemon_name} Health: {pokemon_health}")
    print(f"{ai_name} Health: {ai_health}")

    # Player chooses an action
    action = input(f"Choose an action for {pokemon_name}: Attack (1), Special Attack (2): ")

    if action == '1':
        # Regular attack damage between 10 and 20
        damage = random.randint(10, 20)
        # Apply damage to AI's health
        ai_health -= damage
        print(f"{pokemon_name} used Attack and dealt {damage} damage!")

    elif action == '2':
        # Special attack damage between 5 and 25
        damage = random.randint(5, 25)
        # Apply damage to AI's health
        ai_health -= damage
        print(f"{pokemon_name} used Special Attack and dealt {damage} damage!")

    else:
        print("Invalid action. Please choose 1 or 2.")
        continue

    # Check if AI is defeated
    if ai_health <= 0:
        print(f"{ai_name} has been defeated! {pokemon_name} wins!")
        break

    # ----- AI's Turn -----
    # AI randomly chooses an action (1 or 2)
    ai_action = random.choice(['1', '2'])

    if ai_action == '1':
        # Regular attack damage between 10 and 20
        damage = random.randint(10, 20)
        # Apply damage to player's Pokémon
        pokemon_health -= damage
        print(f"{ai_name} used Attack and dealt {damage} damage!")

    elif ai_action == '2':
        # Special attack damage between 5 and 25
        damage = random.randint(5, 25)
        # Apply damage to player's Pokémon
        pokemon_health -= damage
        print(f"{ai_name} used Special Attack and dealt {damage} damage!")

# Battle result
if pokemon_health <= 0:
    print(f"{pokemon_name} has been defeated! {ai_name} wins!")
else:
    print(f"{pokemon_name} has won the battle against {ai_name}!")
