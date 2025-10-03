#Read a list of integers from input for rows and columns

#Create a 2D list to hold the integers (This is called your matrix)

#Loop through and fill the matrix

#Take an input for a scaling factor

#Loop through the matrix rows

    #Loop through the matrix columns

    #Print the element multiplied by the scaling factor

'''
rows, cols = map(int, input().split())
matrix = []
for _ in range(rows):
    matrix.append(list(map(int, input().split())))
scale = int(input())
for row in matrix:
    for element in row:
        print(element * scale, end=" ")
    print()
'''