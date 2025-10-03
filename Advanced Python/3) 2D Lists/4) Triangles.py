# Take an integer input for the number of rows and columns
rows = columns = int(input())

# Create a 2D List with dynamic dimensions
matrix = [[0 for _ in range(columns)] for _ in range(rows)]

# Loop through the matrix rows

    # Loop through the matrix columns
    
        # If the row and column are equal to the rows - 1
        
        # Print 1 and a space
        
        # Else if the row and column are greater than the rows - 1
        
        # Print 2 and a space
        
        # Else
        
        # Print 0 and a space



'''
rows = columns = int(input())

matrix = [[0 for _ in range(columns)] for _ in range(rows)]

for row in range(rows):
  for column in range(columns):
    if row+column == rows - 1:
      print(1, end = " ")
    elif row+column > rows - 1:
      print(2, end = " ")
    else:
      print(0, end = " ")
  print()
'''