""" write a python program to get a single string from two given strings.separated by a space
and swap the first two charcaters of each string
    sample string:'abc','xyz'
    expected string:'xycabz'
"""
str1=input("enter a first string")
str2=input("enter a second string")
newstr=str2[0:2]+str1[2:]+str1[0:2]+str2[2:]
print(newstr)
