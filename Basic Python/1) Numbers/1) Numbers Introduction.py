# For this section you need to know how to get different digits

# Let's start with basic division
# 1) BASIC DIVISION (/)
#   1234  /  10    = 123 . 4
#   1234  /  100   = 12 . 34
#   1234  /  1000  = 1 . 234

# Remember that Floor Division gets rid of the decimal part
# 2) FLOOR DIVISION (//) - LEFT MOST DIGITS
#   1234  //  10   = 123
#   1234  //  100  = 12
#   1234  //  1000 = 1

# Remainder gives you the leftover part of the division
# 3) REMAINDER (%) - RIGHT MOST DIGITS
#   1234  %  10    =       4
#   1234  %  100   =      34
#   1234  %  1000  =     234


# Now how would you get only the tens digit?
# You can use both Floor Division and Remainder together

# First, get the last two digits with Remainder
# 1234  %  100   =      34
# Then, get rid of the last digit with Floor Division
# 34    //  10    =      3
