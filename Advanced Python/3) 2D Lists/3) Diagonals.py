# Take an integer input

# Create two variables to hold the rows and columns and set them to the input variable

# Create a 2D list to hold the integers (This is called your matrix)

# Loop through the rows

    # Create a variable to hold the row list and set it to an empty list

    # Loop through the columns
    
        # Add the element to the row list variable

    # Add the row list variable to the matrix variable

# Loop through the matrix rows

    # Loop through the matrix columns
    
        # Print the element if the row and column are the same
        
    # Print a space

        

'''
n = int(input())
rows = n
columns = n
matrix =[]

for row in range(rows):
  rowlist = []
  for column in range(columns):
    rowlist.append("x")
  matrix.append(rowlist)

for row in range(rows):
  for column in range(columns):
    print(abs(row - column), end=" ")
  print()
'''