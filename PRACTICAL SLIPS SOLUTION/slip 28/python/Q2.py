# Write a Python program to accept two lists and merge the two lists into list of tuple.
lst1=[1,2,3,5]
lst2=["Yews national senior college"]

t3=list()
t3.append(lst1)
t3.append(lst2)

t4=[tuple(t3[0]),tuple(t3[1])]
print(t4)
