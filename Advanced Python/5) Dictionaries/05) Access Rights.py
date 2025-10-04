# Read the number of file system entries

# Create a dictionary to store the file system

# Iterate through the number of file system entries

    # Read the file system entry

    # Split the file system entry into the filename and the permissions

    # If the filename is not in the dictionary, add it with an empty list

    # If the permission is "R", add "read" to the list

    # If the permission is "W", add "write" to the list

    # If the permission is "X", add "execute" to the list


# Read the number of actions

# Iterate through the number of actions
    # Read the action and the filename (make sure to split the input)
    
    # If the action is in the dictionary and the filename, print "OK"
    
    # Else, print "Access denied"

# Print the result with a newline between each action and without a space at the end (end = "")



'''
count = int(input())
filesys = dict()

for i in range(count):
  line = input().split()
  filename = line[0]
  
  filesys[filename] = []

  if "R" in line:
    filesys[filename].append("read")
  if "W" in line:
    filesys[filename].append("write")
  if "X" in line:
    filesys[filename].append("execute")


count2 = int(input())

for j in range(count2):
  action, filename = input().split()

  if action in filesys[filename]:
    print("OK")
  else:
    print("Access denied")

# print("\n".join(responses), end = "")
'''