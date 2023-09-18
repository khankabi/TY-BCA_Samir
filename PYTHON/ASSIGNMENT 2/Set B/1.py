"""write a python program to get a string made of the first 2 and the last 2 chars from
a given a string. if the string length less than 2,return instead of the empty string.
    sample string:'General12'
    expected string:'Ge12'
    sample string:'ka'
    expected string:'kaka'
    sample string:'k'
    expected string:'empty string'
    """

str=input("Enter a String :")
if len(str)>=2:
    str1=str[0:3]+str[0:-3]
else:
    str1="Empty String"
print(str1)
