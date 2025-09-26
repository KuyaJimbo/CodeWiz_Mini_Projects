import random

# Create Deck of Cards
Deck =  4 * [1,2,3,4,5,6,7,8,9,10,10,10,10]
random.shuffle(Deck)

# Deal Cards 2 cards to Player and Dealer
Player_Hand = [Deck.pop(), Deck.pop()]
Dealer_Hand = [Deck.pop(), Deck.pop()]

# Show Player Cards
print(f"Your cards: {Player_Hand}, current score: {sum(Player_Hand)}")
print(f"Dealer's first card: {Dealer_Hand[0]}")

# Ask the Player if they want to draw a Card
while sum(Player_Hand) < 21:
    option = input("(H)it or (S)tand: ").lower()
    if option == 'h':
        Player_Hand.append(Deck.pop())
        print(f"Your cards: {Player_Hand}, current score: {sum(Player_Hand)}")
    elif option == 's':
        break
    else:
        print("Invalid option. Please choose (H)it or (S)tand.")

# Dealer's turn to draw cards
while sum(Dealer_Hand) < 17:
    Dealer_Hand.append(Deck.pop())

# Show final hands and determine winner
print(f"Your final hand: {Player_Hand}, final score: {sum(Player_Hand)}")
print(f"Dealer's final hand: {Dealer_Hand}, final score: {sum(Dealer_Hand)}")

# Determine the winner
if sum(Player_Hand) > 21:
    print("You went over. You lose!")
elif sum(Dealer_Hand) > 21 or sum(Player_Hand) > sum(Dealer_Hand):
    print("You win!")
else:
    print("You lose!")