#write a python program to create a union of sets
#union return all values from sets without common value
setc1=set(["Naruto","Sasuke"])
setc2=set(["Naruto","Itachi"])
print("Original sets are : ")
print(setc1)
print(setc2)
setc=setc1.union(setc2)
print("Union of above sets: ")
print(setc)

#another example with number
setn1=set([1,2,3,4,5,6,7,8,9])
setn2=set([2,4,6,8])
print("Original sets are : ")
print(setn1)
print(setn2)
setn=setn1.union(setn2)
print("Union of above sets: ")
print(setn)





