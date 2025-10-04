'''
- set(input().split()) - Converts the input into a set of numbers

- .intersection() - Finds elements that exist in both sets

- len() - Counts how many elements are in the intersection:
    This gives us the number of common elements between the two sets
'''

print(len( (set(input().split())).intersection(set(input().split())) ), end = "")
