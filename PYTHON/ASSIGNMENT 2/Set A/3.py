""" write a python program to remove the charcters which have odd index values of given string."""
#first method
str  = input("Enter the string:")
for char in str:
    if str.index(char) %2!=0:
        print(str.index(char),"remove",char)

#second method
str2 = input("Enter the string:")
result_string=" "
for i in range(len(str2)):
    if i %2!=0:
        result_string=result_string+str2[i]
print("remove",result_string)
