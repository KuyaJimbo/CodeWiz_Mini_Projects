import random

player = 0
dealer = 0

# Simulate Player's Turn
while True:
    print("Score :", player)
    print("hit or stay?")
    choice = input()
    if choice == "hit":
        player += random.randint(1,10)
    elif choice == "stay":
        break
    else:
        print("Please enter (hit) or (stay)")

# Simulate Dealer's Turn
while dealer < 15:
    dealer += random.randint(1,10)
    
if player > 21:
    print("You Lose!")
elif player < dealer and dealer < 21:
    print("You Lose!")
else:
    print("You Win!")
