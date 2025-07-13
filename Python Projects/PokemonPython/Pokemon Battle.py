import random

pokemon_name = input("Enter the name of the Pokemon: ")
ai_name = "Pikachu"

pokemon_health = 100
ai_health = 100

while pokemon_health > 0 and ai_health > 0:
    print(f"\n{pokemon_name} Health: {pokemon_health}")
    print(f"{ai_name} Health: {ai_health}")

    action = input(f"Choose an action for {pokemon_name}: Attack (1), Special Attack (2)")

    if action == '1':
        damage = random.randint(10, 20)
        ai_health -= damage
        print(f"{pokemon_name} used Attack!")

    elif action == '2':
        damage = random.randint(5, 25)
        ai_health -= damage
        print(f"{pokemon_name} used Special Attack!")

    else:
        print("Invalid action. Please choose 1 or 2.")
        continue
    
    if ai_health <= 0:
        print(f"{ai_name} has been defeated! {pokemon_name} wins!")
        break

    # AI's turn
    ai_action = random.choice(['1', '2'])

    if ai_action == '1':
        damage = random.randint(10, 20)
        pokemon_health -= damage
        print(f"{ai_name} used Attack!")

    elif ai_action == '2':
        damage = random.randint(5, 25)
        pokemon_health -= damage
        print(f"{ai_name} used Special Attack!")
    
if pokemon_health <= 0:
    print(f"{pokemon_name} has been defeated! {ai_name} wins!")
else:
    print(f"{pokemon_name} has won the battle against {ai_name}!")