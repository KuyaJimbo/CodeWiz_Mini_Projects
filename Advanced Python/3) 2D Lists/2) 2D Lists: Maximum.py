# Get a list of integers from input for rows and columns

# Create a 2D list to hold the integers(This is called your matrix)

# Loop through and fill the matrix

# Create a variable to hold the maximum value and set it 0

# Create two variables to hold the index (row and column) 
# of the maximum value and set them to 0


# Loop through the matrix rows

    # Loop through the matrix columns
    
        # If the maximum value is greater than or equal to the element
        
        # Continue

        # else
        
            # Set the maximum value to the current element
            
            # Set the index of the maximum value to the current row and column variables

#Print the index of the maximum value (row and column)

'''
rows, cols = map(int, input().split())

matrix = []

for row in range(rows):
    line = list(map(int, input().split()))
    matrix.append(line)

max = 0
maxRow = 0
maxCol = 0

for row in range(rows):
    for col in range(cols):
        if max >= matrix[row][col]:
            continue
        else:
            max = matrix[row][col]
            maxRow = row
            maxCol = col
            
print(maxRow, maxCol, end="")
'''