#Read an input:
a = [int(s) for s in input().split()]

#Create a new list to hold the elements that 
#have the same sign as the left neighbor

#Create a variable called "Found" and set it to False

#Loop through the list (starting at index 1)

    #If the element and its left neighbor are both positive or both negative
    
        #Print the current index and its left neighbor

        #Set Found to True

        #Break the loop
        
#If not found, print 0

'''
a = [int(s) for s in input().split()]

found = False

for i in range(1, len(a)):
  if (a[i] > 0 and a[i - 1] > 0) or (a[i] < 0 and a[i - 1] < 0):
    print(i - 1, a[i - 1])
    found = True
    break

if not found:
  print(0)
'''