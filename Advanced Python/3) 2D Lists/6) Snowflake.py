# Read an integer input for the size of the matrix
n = int(input())

# Initialize the matrix with dots
matrix = [['.' for _ in range(n)] for _ in range(n)]

# Loop through the matrix rows

    # Loop through the matrix columns

    # If the row is equal to the column OR the row + column is equal to n - 1 
    # (n is the size of the matrix)

        # Set the element to '*'

# Loop through the matrix rows

    # Print the matrix[row] with a space between each element (* in front)


'''
n = int(input())  # Input size of matrix
matrix = [['.' for _ in range(n)] for _ in range(n)]  # Initialize matrix with dots

for row in range(n):
    for col in range(n):
        if row == col or row + col == n - 1:  # Diagonals get '*'
            matrix[row][col] = '*'

# Print the matrix
for row in matrix:
    print(' '.join(row))
'''