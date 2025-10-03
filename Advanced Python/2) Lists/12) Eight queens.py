# Initialize an empty list to store the coordinates of the queens
queens = []


# Input the coordinates of the queens
for Q in range(8):
    x, y = map(int, input().split())  # Input the coordinates as integers
    queens.append((x, y))  # Add the coordinates to the list of queens

# Initialize a variable to store if placement is invalid
invalid = True


# Iterate through each queen's coordinates

    # Coordinates of the first queen
    
    # Iterate through each next queen's coordinates
    
        # Coordinates of the second queen


        # Check if queens are in the same row
        
            # Exit the inner loop


        # Check if queens are in the same column
        
            # Exit the inner loop


        # Check if queens are in the same diagonal
        
            # Exit the inner loop


    # If invalid is already False, exit the outer loop as well
        


# Print the final result based on the value of invalid



'''
queens = []


for Q in range(8):
    x, y = map(int, input().split())  # Input the coordinates as integers
    queens.append((x, y))  # Add the coordinates to the list of queens


invalid = True


for Q1 in range(len(queens)):
    row1, col1 = queens[Q1]  # Coordinates of the first queen
    
    for Q2 in range(Q1 + 1, len(queens)):
        row2, col2 = queens[Q2]  # Coordinates of the second queen


        if row1 == row2:
            invalid = False
            break  # Exit the inner loop


        elif col1 == col2:
            invalid = False
            break  # Exit the inner loop


        elif abs(row1 - row2) == abs(col1 - col2):
            invalid = False
            break  # Exit the inner loop


    if not invalid:
        break


if invalid:
    print("NO")
else:
    print("YES")
'''