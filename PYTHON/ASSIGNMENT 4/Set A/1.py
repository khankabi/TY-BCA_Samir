# Write a recursive function which print string in reverse order.
def reverse(s):
    str = ""
    for i in s:
        str = i + str
    return str
 
s = "National senior college"
 
print("The original string is : ", end="")
print(s)
 
print("The reversed string(using loops) is : ", end="")
print(reverse(s))