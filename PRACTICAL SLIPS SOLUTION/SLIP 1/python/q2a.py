# write a python program to accept n number in list and remove duplicates from a list.
n=int(input("Enter number of element : "))
listx=[]
for i in range(n):
    item=int(input("Enter a Number: "))
    listx.append(item)
print(listx)
listx=set(listx)
print(listx)


