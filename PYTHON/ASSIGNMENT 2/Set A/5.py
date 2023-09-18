""" write a python program to get a string from a given string where all occurrences of its first
char have been changed to '$', except the first char itself.
    sample string:'restart'
    expected string:'resta$t'
"""
str= input("enter a string:")
char = str[0]
str=str.replace(char,'$')
str=char+str[1:]
print(str)

