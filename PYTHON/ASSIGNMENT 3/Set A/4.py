#write a python program to create intersection of sets
# The returned set contains only items that exist in both sets, or in all sets if the comparison is done with more than two sets.
#intersection() and & are used for intersection of sets
setc1=set(["White","Black"])
setc2=set(["Black","Green"])
print("Original sets")
print(setc1)
print(setc2)
setc=setc1.intersection(setc2)
#setc=setc1 & setc2
print("\n Intersection Of above sets:")
print(setc)

