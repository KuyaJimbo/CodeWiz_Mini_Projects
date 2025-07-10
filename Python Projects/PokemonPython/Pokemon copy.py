import random

pokemon_name = input("Enter the name of the Pokemon: ")
pokemon_type = input("Enter the type of the Pokemon: ")
first_attack = input("Enter the name of the first attack: ")
second_attack = input("Enter the name of the second attack: ")

def create_pokemon(name, type, attack1, attack2):
    return {
        "name": name,
        "type": type,
        "attacks": [attack1, attack2],
        "health": 100
    }

pokemon = create_pokemon(pokemon_name, pokemon_type, first_attack, second_attack)

print(f"\n{pokemon['name']} the {pokemon['type']} Pokemon is ready for battle!")


attack1 = random.randint(10, 20)
attack2 = random.randint(5, 25)

ai_attack1 = random.randint(10, 20)
ai_attack2 = random.randint(5, 25)

while pokemon_health > 0 and ai_health > 0:
    print(f"\n{pokemon_name} Health: {pokemon_health}")
    print(f"{ai_name} Health: {ai_health}")

    action = input(f"Choose an action for {pokemon_name}: Attack1 (1), Attack2 (2)")

    if action == '1':
        ai_health -= attack1
        print(f"{pokemon_name} used Attack1! {ai_name}")

    elif action == '2':
        ai_health -= attack2
        print(f"{pokemon_name} used Attack2! {ai_name}")

    else:
        print("Invalid action. Please choose 1 or 2.")
        continue
    
    if ai_health <= 0:
        print(f"{ai_name} has been defeated! {pokemon_name} wins!")
        break

    # AI's turn
    ai_action = random.choice(['1', '2'])

    if ai_action == '1':
        pokemon_health -= ai_attack1
        print(f"{ai_name} used Attack1!")

    elif ai_action == '2':
        pokemon_health -= ai_attack2
        print(f"{ai_name} used Attack2!")