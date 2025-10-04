# Read the number of countries


# Create a dictionary to store the countries and cities

# Iterate through the number of countries

    # Read the country and cities (make sure to split the input)

    # Set the country as the first element of the list

    # Set the cities as the rest of the list

    # Iterate through the cities

        # Add the city to the dictionary with the country

# Iterate through the number of cities

    # Read the city

    # Print the country for the city

'''
countries = int(input())
gpsDict = {}

for i in range(countries):
  line = input().split()
  country = line[0]
  cities = line[1:]

  for city in cities:
    gpsDict[city] = country

cities = int(input())

for j in range(cities):
  city = input()
  print(gpsDict[city])
'''