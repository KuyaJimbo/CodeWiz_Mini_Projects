# Read a list of integers and split it

# Create an empty set to store seen numbers

# Create an empty array to store a 'YES' or 'NO'

# Iterate through the list

    # If the number is not in the set, add 'NO' to the array

    # Add the number to the set

    # Else, add 'YES' to the array

# Print the array with a new line between each element

'''
a = list(input().split())

b = set()

answer = []

for num in a:
  if num not in b:
    answer.append("NO")
    b.add(num)
  else:
    answer.append("YES")

print("\n".join(answer), end="")
'''