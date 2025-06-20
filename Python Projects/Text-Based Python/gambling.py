import random

cards = list()
symbols = ["clubs", "diamonds", "hearts", "spades"]

for symbol in symbols:
  for rank in range(2,15):
    cards.append((symbol, rank))

for s in range(3):
  random.shuffle(cards)

print(cards)

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

print("FULL TABLE: ", table)

all_cards = table +  player_hand + dealer_hand + cards
print(all_cards)

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
  Best = bestCard[cards]
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
  pass

def threeOfAKind(cards):
  pass

def twoPair(cards):
  pass

def onePair(cards):
  pass

def highCard(cards):
    return bestCard(cards)

def evaluateHand(cards):
    if royalflush(cards):
        return "Royal Flush"
    elif Flush(cards):
        return "Flush"
    elif Straight(cards):
        return "Straight"
    elif fourOfAKind(cards):
        return "Four of a Kind"
    elif threeOfAKind(cards):
        return "Three of a Kind"
    elif twoPair(cards):
        return "Two Pair"
    elif onePair(cards):
        return "One Pair"
    else:
        return "High Card: " + str(highCard(cards))


# Example usage
print("Player's best hand: ", evaluateHand(player_hand + table))
print("Dealer's best hand: ", evaluateHand(dealer_hand + table))

# Determine the winner
player_best = evaluateHand(player_hand + table)
dealer_best = evaluateHand(dealer_hand + table)

if player_best == dealer_best:
    print("It's a tie!")
elif player_best > dealer_best:
    print("Player wins!")
else:
    print("Dealer wins!")
