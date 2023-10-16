#write a python program to add item in a tuple.
#Create a tuple
tuplex=(4,6,8,10,12)
print("Original tuple:")
print(tuplex)
#tuple are immutable, so you can not add new elements
#using merge of tuples with the + operator you can add an element and it will create a new tuple
print("Tuple after + operation")
tuplex=tuplex+(14,)
print(tuplex)
#adding items in a specific index
print("Tuple after adding items in a specific index")
tuplex=tuplex[:5]+(16,18,20)+tuplex[5:]
print(tuplex)
#converting the tuple to list
listx=list(tuplex)
#use different ways to add items in list
listx.append(30)
tuplex=tuple(listx)
print("Tuple after converting into list and using different funtion with it")
print(tuplex)
