# Read a list of integers and split them into a set

# Read a second list of integers and split them into a set

# Find the intersection of the two sets and set it to a variable

# Sort the intersection

# Print the intersection

'''
a = set(input().split())
b = set(input().split())
c = a.intersection(b)
c = sorted(c)
print(*c, end = "")
'''