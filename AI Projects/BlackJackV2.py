import random

wins = 0

for round in range(10):
    cards = 4 * [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10]
    random.shuffle(cards)

    player_hand = [cards.pop(), cards.pop()]
    dealer_hand = [cards.pop()]

    while sum(player_hand) < 21:
        print(f"Your hand: {player_hand}, total: {sum(player_hand)}")
        print(f"Dealer's hand: {dealer_hand}, total: {sum(dealer_hand)}")
        action = input("Do you want to hit or stand? (h/s): ").strip().lower()
        if action == 'h':
            player_hand.append(cards.pop())
        else:
            break
    
    while sum(dealer_hand) < 17:
        dealer_hand.append(cards.pop())

    if sum(player_hand) > 21:
        pass
    elif sum(dealer_hand) > 21:
        pass
    elif sum(player_hand) > sum(dealer_hand):
        pass
    else:
        pass

print(wins)