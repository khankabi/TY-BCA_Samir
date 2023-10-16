#write a python program to create a list of tuples with the first element as the number and second element
#as the square of the number
my_list=[23,42,67,89,11,32]
print("Original list is: ")
print(my_list)
print("The resultant tuple is: ")
my_result=[(val,pow(val,2)) for val in my_list]
print(my_result)