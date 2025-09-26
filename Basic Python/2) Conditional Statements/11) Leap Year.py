# Remember Remainder Division?
# We can use it to determine if a year is a leap year or not.

# Read an integer for the year
year = int(input())

# if year divided by 400 has a remainder of 0:
# 400 % 400 = 0     LEAP
# 800 % 400 = 0     LEAP
# 801 % 400 = 1     COMMON
# 802 % 400 = 2     COMMON

if year % 400 == 0:
  print("LEAP")

# else if (year divided by 100 has a remainder that is not 0) and (year divided by 4 has a remainder of 0):



# else, its not a leap year, its COMMON
