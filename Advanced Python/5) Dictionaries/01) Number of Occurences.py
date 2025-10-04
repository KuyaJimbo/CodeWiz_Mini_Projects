# Read a string and split it into a list of words

# Create a dictionary to store the number of occurrences of each word

# Create a list to store the result

# Iterate through the list of words

    # Get the current count of the word (0 if the word hasn't been seen yet)
    
    # Add the count to the result list
    
    # Increment the count for the word

# Print the result list with a space between each count


'''
words = input().split()
word_count = {}
result = []

for word in words:
    count = word_count.get(word, 0)
    result.append(str(count))
    
    word_count[word] = count + 1

print(" ".join(result), end="")
'''