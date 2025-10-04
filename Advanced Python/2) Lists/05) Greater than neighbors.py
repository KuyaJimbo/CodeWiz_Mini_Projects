#Read an input:
a = [int(s) for s in input().split()]

#Create a counter variable and set it to 0


#Loop through the list (starting at index 1 and ending at the second to last index)

    #If the element is greater than the left neighbor and the right neighbor
    
        #Increment the counter by 1
        
#Print the counter variable

'''
a = [int(s) for s in input().split()]

count = 0

for i in range(1, len(a) - 1):
  if (a[i] > a[i - 1]) and (a[i] > a[i + 1]):
    count += 1

print(count)
'''