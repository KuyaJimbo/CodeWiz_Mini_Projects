# Read the number of vote entries

# # Create a dictionary to store candidate names and their vote totals

# # Create a set to track unique candidate names for final output

# Iterate through the number of vote entries

        # Read the candidate name and number of votes from input

        # If this is the first time we see this candidate

            # Initialize the candidate's vote count in the dictionary

            # Add the name to the set to track unique candidates

    

    # Else, add the votes to the existing candidate's total



# Iterate through the sorted candidate names

    # Print the candidate name and their total votes



'''
count = int( input () )
Election = dict ()
Names = set()

for i in range(count):
        name, votes = input().split()
        if name not in Election:
                Election[ name ] =  int( votes )
                Names.add(name)
        else:
                Election[ name ] +=  int( votes )

for name in sorted(Names):
  
  print(name, Election[ name ])
'''