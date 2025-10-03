# Read number of pins and balls
N, K = map(int, input().split())

# Start with all pins standing, represented by 'I'
pins = ['I'] * N

# Knock down pins based on each ball's range

    # Convert to 0-based indexing and knock down pins in range
    

# Output final pin states as a single string


'''
N, K = map(int, input().split())

pins = ['I'] * N

for _ in range(K):
    l, r = map(int, input().split())

    for i in range(l - 1, r):
        pins[i] = '.'

print(''.join(pins))
'''