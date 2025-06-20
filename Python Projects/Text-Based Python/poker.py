import random

# Generate deck
cards = []
suits = ["clubs", "diamonds", "hearts", "spades"]
for suit in suits:
    for rank in range(2, 15):  # 11=Jack, 12=Queen, 13=King, 14=Ace
        cards.append((suit, rank))

# Shuffle deck
random.shuffle(cards)

# Deal cards
player_hand = [cards.pop(), cards.pop()]
dealer_hand = [cards.pop(), cards.pop()]
table = [cards.pop(), cards.pop(), cards.pop(), cards.pop(), cards.pop()]

# Print hands
print("PLAYER:", player_hand)
print("DEALER:", dealer_hand)
print("TABLE:", table)

# Helper Functions
def getBestCard(cards):
    suit_rank = {"clubs": 0, "diamonds": 1, "hearts": 2, "spades": 3}
    best_card = cards[0]
    for card in cards:
        best_suit, best_rank = best_card[0], best_card[1]
        card_suit, card_rank = card[0], card[1]

        if card_rank > best_rank:
            best_card = card
        elif card_rank == best_rank:
            if suit_rank[card_suit] > suit_rank[best_suit]:
                best_card = card

    return best_card

# Flush is determined by checking if all cards have the same suit
def isFlush(cards):
    suit = cards[0][0]
    for card in cards:
        card_suit = card[0]
        if card_suit != suit:
            return False
    return True

# Straight is determined by checking if the ranks form a consecutive sequence
def isStraight(cards):
    best_card = getBestCard(cards)
    highest_rank = best_card[1]
    Numbers = [card[1] for card in cards]
    for rank in range(highest_rank, highest_rank - 5, -1):
        if rank not in Numbers:
            return False
    return True

# Straight Flush is a combination of Flush and Straight
def isStraightFlush(cards):
    return isFlush(cards) and isStraight(cards)

# Royal Flush is a special case of Straight Flush where the highest card is an Ace
def isRoyalFlush(cards):
    if isStraightFlush(cards):
        best_card = getBestCard(cards)
        best_rank = best_card[1]
        if best_rank == 14:
            return True
    return False

# Order of hand rankings
hand_rankings = {
    "Royal Flush": 10,
    "Straight Flush": 9,
    "Four of a Kind": 8,
    "Full House": 7,
    "Flush": 6,
    "Straight": 5,
    "Three of a Kind": 4,
    "Two Pair": 3,
    "One Pair": 2,
    "High Card": 1
}

def _ofAKind(cards, n):
    rank_count = {}
    for card in cards:
        rank = card[1]
        if rank in rank_count:
            rank_count[rank] += 1
        else:
            rank_count[rank] = 1
    for count in rank_count.values():
        if count == n:
            return True
    return False