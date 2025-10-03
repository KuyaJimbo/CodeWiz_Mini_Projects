# Read an integer input for the number of rows and columns
rows, columns = map(int, input().split())

# Create an empty 2D List (This is called your matrix)

# Loop through the matrix rows
    
        # Add the integer input to the matrix
        
# Read an integer input for the two columns to swap

# Loop through the matrix rows
    
        # Swap the two columns
        
# Loop through the matrix rows
    
        # Print the matrix[row] with a space between each element (* in front)



'''
rows, columns = map(int, input().split())
matrix = []
for _ in range(rows):
  matrix.append(list(map(int, input().split())))

column1, column2 = map(int, input().split())
for row in range(rows):
  matrix[row][column1], matrix[row][column2] = matrix[row][column2], matrix[row][column1]
for row in range(rows):
  print(*matrix[row])
'''