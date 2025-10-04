#Read a list of integers
a = [int(s) for s in input().split()]

#Create a variable to hold the minimum value and set it to the first element

#Create a variable to hold the maximum value and set it to the first element

#Create a variable to hold the index of the minimum value and set it to 0

#Create a variable to hold the index of the maximum value and set it to 0


#Loop through the list

    #If the element is less than the minimum value
    
        #Set the minimum value to the element

        #Set the index of the minimum value to the current index
    
    #Else if the element is greater than the maximum value
    
        #Set the maximum value to the element

        #Set the index of the maximum value to the current index

#Swap the minimum and maximum values


#Print the list

'''
a = [int(s) for s in input().split()]

min = a[0]
minIndex = 0
max = a[0]
maxIndex = 0

for index in range(len(a)):
  if a[index] < min:
    min = a[index]
    minIndex = index
  elif a[index] > max:
    max = a[index]
    maxIndex = index

a[minIndex], a[maxIndex] = a[maxIndex], a[minIndex]

print(*a)
'''