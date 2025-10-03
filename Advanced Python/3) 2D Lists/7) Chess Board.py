# Read an integer input for the number of rows and columns
NUM_ROWS, NUM_COLS = input().split()
NUM_ROWS = int(NUM_ROWS)
NUM_COLS = int(NUM_COLS)

# Creating a 2D list with dynamic dimensions
grid = [[0 for _ in range(NUM_COLS)] for _ in range(NUM_ROWS)]

# Loop through the matrix rows

    # Create a temporary list

    # Loop through the matrix columns

        # If the row + column is even
        
            # Print a dot(end=" ")

        # Else
        
            # Print a star(end=" ")

    # Print a new line


'''
NUM_ROWS, NUM_COLS = input().split()
NUM_ROWS = int(NUM_ROWS)
NUM_COLS = int(NUM_COLS)

grid = [[0 for _ in range(NUM_COLS)] for _ in range(NUM_ROWS)]

for row in range(NUM_ROWS):
  temp = []
  for column in range(NUM_COLS):
    if (row+column) % 2 == 0:
      print(".", end= " ")
    else:
      print("*", end= " ")
  print()
'''