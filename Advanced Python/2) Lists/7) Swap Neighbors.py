# Read a list of numbers
line = input().strip()

# If input is empty, print nothing

#else
    # Convert tokens to integers
    #nums = list(map(int, line.split()))

    # Swap neighbors in-place: (0<->1), (2<->3), ...


    # Print the result space-separated



'''
line = input().strip()

if not line:
    print()
else:
    nums = list(map(int, line.split()))
    for i in range(1, len(nums), 2):
        nums[i - 1], nums[i] = nums[i], nums[i - 1]
    print(*nums)
'''