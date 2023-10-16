#  write a python program to create set difference and a symmetric difference.
setc1=set(["green","blue"])
setc2=set(["blue","yellow"])
print("Original sets : ")
print(setc1)
print(setc2)
r1=setc1.symmetric_difference(setc2)
print("Symmetric difference of setc1 - setc2: ")
print(r1)
r2=setc2.symmetric_difference(setc1)
print("Symmetric difference of setc2 - setc1: ")
print(r2)
setn1=set([1,1,2,3,4,5])
setn2=set([1,5,6,7,8,9])
print("Original sets : ")
print(setn1)
print(setn2)
r1=setn1.symmetric_difference(setn2)
print("Symmetric difference of setc1 - setc2: ")
print(r1)
r2=setn2.symmetric_difference(setn1)
print("Symmetric difference of setc2 - setc1: ")
print(r2)





