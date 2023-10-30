# Write a python program to accept string and remove the characters which have odd index values of given string using user defined function.
def odd_index_string(str):
    result=""
    for i in range(len(str)):
        if i%2==0:
            result+=str[i]
    return result
str=input("Enter a string: ")
odd_index=odd_index_string(str)
print(f"Original string: {str}")
print(f"String after removing odd index values: {odd_index}")
