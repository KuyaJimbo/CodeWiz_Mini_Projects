import random

class Pokemon:
    def __init__(self, name, health, moves):
        self.name = name
        self.health = health
        self.moves = moves

    def action(self):
        move = random.choice(self.moves)
        damage = random.randint(10, 20)
        print(f"{self.name} used {move}!")
        return damage
    
    def is_defeated(self):
        return self.health <= 0
    
    def take_damage(self, damage):
        self.health -= damage
        if self.health < 0:
            self.health = 0

    def get_health(self):
        return self.health


types = ["Water", "Fire", "Grass"]
water_moves = ["Water Gun", "Bubble Beam", "Hydro Pump"]
fire_moves = ["Ember", "Flamethrower", "Fire Blast"]
grass_moves = ["Vine Whip", "Razor Leaf", "Solar Beam"]

while True:

    pokemon_name = input("Enter the name of your Pokemon: ")
    pokemon_type = input("Choose a type: Water (1), Fire (2), Grass (3): ")

    if pokemon_type == '1':
        pokemon = Pokemon(pokemon_name, 100, water_moves)
        break
    elif pokemon_type == '2':
        pokemon = Pokemon(pokemon_name, 100, fire_moves)
        break
    elif pokemon_type == '3':
        pokemon = Pokemon(pokemon_name, 100, grass_moves)
        break
    else:
        print("Invalid type. Please choose 1, 2, or 3 (Water, Fire, Grass).")
        continue

while True:
    print(f"\nYour Pokemon: {pokemon.name} (Type: {pokemon_type})")

pokemon_health = 100


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