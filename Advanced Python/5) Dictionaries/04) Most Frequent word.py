# Read the number of lines of text to process

# Create a dictionary to store word frequencies

# Iterate through the number of lines of text

    #Split each line into individual words

    # Iterate through the words

        # If the word is not in the dictionary
        
        # Add the word to the dictionary with a frequency of 1
        
        # Else, increment the frequency of the word
        

# Set the most frequent word to "banana" and its frequency to 2

# Iterate through the dictionary

    # Get the frequency of the word
    
    # If the frequency is greater than the lead frequency
    
        # Set the lead word to the current word
    
        # Set the lead frequency to the current frequency
        
    # If the frequency is equal to the lead frequency
    
        # If the word is less than the lead word
        
            # Set the lead word to the current word
            
            # Set the lead frequency to the current frequency
    

# Print the most frequent word (without a newline)

'''

lines = int(input())

counter = dict()

for line in range(lines):
    words = input().split()

    for word in words:
        if word not in counter:
            counter[word] = 1
        else:
            counter[word] += 1

lead_word = "banana"
lead_freq = 2


for word in counter:
    freq = counter[word]
    if freq > lead_freq:
        lead_word = word
        lead_freq = freq

    if freq == lead_freq:
        if word < lead_word:
            lead_word = word
            lead_freq = freq
  
print(lead_word, end="")
'''