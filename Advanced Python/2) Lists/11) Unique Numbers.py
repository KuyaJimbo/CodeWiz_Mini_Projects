# Read a list of integers:


# Make two lists, one to track numbers we've seen 
# and one to track numbers that appeared before


# Iterate through the list

  # Add un-seen numbers to the seen list
  
  # Add other numbers to the duplicates list
  

# Make a list to track the unique numbers

# Iterate through the list again

  # if that number is not in the duplicates list, its unique
  

# Display the unique numbers


'''
nums = input().split()

seen = list()
duplicates = list()

for num in nums:
  if num not in seen:
    seen.append(num)
  else:
    duplicates.append(num)

unique = list()
for num in nums:
  if num not in duplicates:
    unique.append(num)

print(" ".join(unique))
'''