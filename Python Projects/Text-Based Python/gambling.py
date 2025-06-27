import random

cards = list()
symbols = ["clubs", "diamonds", "hearts", "spades"]

for symbol in symbols:
  for rank in range(2,15):
    cards.append((symbol, rank))

for s in range(3):
  random.shuffle(cards)

# print(cards)

player_hand = list()
dealer_hand = list()
table = list()


player_hand.append(cards.pop())
player_hand.append(cards.pop())

print("PLAYER: ", player_hand)


dealer_hand.append(cards.pop())
dealer_hand.append(cards.pop())

print("Dealer: ", dealer_hand)

table.append(cards.pop())
table.append(cards.pop())
table.append(cards.pop())
table.append(cards.pop())
table.append(cards.pop())

print("FULL TABLE: ", table)

# all_cards = table + player_hand + dealer_hand + cards
# print(all_cards)

def bestCard(cards):
  suitranking = {"clubs":0,"diamonds":1,"hearts":2,"spades":3}
  best = cards[0]
  for card in cards:
    if best[1] < card[1]:
      best = card
    elif best[1] == card[1]:
      if suitranking[best[0]]<suitranking[card[0]]:
        best = card
  return best

def Flush(cards):
    suit1 = cards[0][0]
    for card in cards:
        if card[0] != suit1:
            return False
    return True

def Straight(cards):
  Best = bestCard(cards)
  Highest = Best[1]
  Numbers = [card[1] for card in cards]
  for rank in range(Highest,Highest-5,-1):
    if rank not in Numbers:
      return False
  return True

def royalflush(cards):
  if Flush(cards):
    if Straight(cards):
      if bestCard(cards)[1] == 14:
        return True
  return False

def fourOfAKind(cards):
    rank_count = {}
    for card in cards:
        rank = card[1]
        if rank in rank_count:
            rank_count[rank] += 1
        else:
            rank_count[rank] = 1
    for count in rank_count.values():
        if count == 4:
            return True
    return False

def threeOfAKind(cards):
    rank_count = {}
    for card in cards:
        rank = card[1]
        if rank in rank_count:
            rank_count[rank] += 1
        else:
            rank_count[rank] = 1
    for count in rank_count.values():
        if count == 3:
            return True
    return False

def twoPair(cards):
    rank_count = {}
    for card in cards:
        rank = card[1]
        if rank in rank_count:
            rank_count[rank] += 1
        else:
            rank_count[rank] = 1
    pairs = 0
    for count in rank_count.values():
        if count == 2:
            pairs += 1
    return pairs == 2

def onePair(cards):
    rank_count = {}
    for card in cards:
        rank = card[1]
        if rank in rank_count:
            rank_count[rank] += 1
        else:
            rank_count[rank] = 1
    pairs = 0
    for count in rank_count.values():
        if count == 2:
            pairs += 1
    return pairs == 1

def fullHouse(cards):
    rank_count = {}
    for card in cards:
        rank = card[1]
        if rank in rank_count:
            rank_count[rank] += 1
        else:
            rank_count[rank] = 1
    has_three = False
    has_two = False
    for count in rank_count.values():
        if count == 3:
            has_three = True
        elif count == 2:
            has_two = True
    return has_three and has_two

def highCard(cards):
    return bestCard(cards)

def evaluateHand(cards):
    if royalflush(cards):
        return "Royal Flush", 9
    elif Flush(cards) and Straight(cards):
        return "Straight Flush", 8
    elif fourOfAKind(cards):
        return "Four of a Kind", 7
    elif fullHouse(cards):
        return "Full House", 6
    elif Flush(cards):
        return "Flush", 5
    elif Straight(cards):
        return "Straight", 4
    elif threeOfAKind(cards):
        return "Three of a Kind", 3
    elif twoPair(cards):
        return "Two Pair", 2
    elif onePair(cards):
        return "One Pair", 1
    else:
        return "High Card", 0

# Determine the best hand for both player and dealer
print("Evaluating hands...")

# generate all possible combinations of a hand (2 cards) and table (5 cards)
# and return the best combination of 5 cards
import itertools 
def bestHand(hand, table):
    combined = hand + table
    best_combination = []
    for combination in itertools.combinations(combined, 5):
        if len(combination) == 5:
            if not best_combination or evaluateHand(combination)[1] > evaluateHand(best_combination)[1]:
                best_combination = combination
    return list(best_combination)

player_hand = bestHand(player_hand, table)
print("Best Player Hand:", player_hand)
dealer_hand = bestHand(dealer_hand, table)
print("Best Dealer Hand:", dealer_hand)

# Determine the winner
player_hand_name, player_strength = evaluateHand(player_hand)
dealer_hand_name, dealer_strength = evaluateHand(dealer_hand)

if player_strength > dealer_strength:
    print("Player wins with:", player_hand_name)
elif dealer_strength > player_strength:
    print("Dealer wins with:", dealer_hand_name)
else:
    # Check for tie-breaking conditions
    print("Split! Both have:", player_hand_name)
