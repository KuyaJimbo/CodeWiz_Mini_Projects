
# Read an integer input 
n = int(input())

# Create a set
x = [str(i) for i in range(1, n+1)]
potentialSet = set(x)

# while True: 
    # Ask the user to guess a number

    # If the user asks for 'HELP', print the remaining possible secret numbers and break the loop

    # If the user guesses a number, make it a set
    
    
    # If the user says 'YES', add the numbers from the set to the potential set
    
    # If the user says 'NO', remove the numbers from the set from the potential set
    



'''
n = int(input())
x = [str(i) for i in range(1, n+1)]
potentialSet = set(x)

while True: 
    guess = input().split()
    if "HELP" in guess:
        result = " ".join(sorted(potentialSet, key=int))
        print(result, end="")
        break
    
    response = input().strip()
    guess_set = set(guess)
    
    if response == "YES":
        potentialSet = potentialSet.intersection(guess_set)
    else:  # response == "NO"
        potentialSet = potentialSet.difference(guess_set)
'''