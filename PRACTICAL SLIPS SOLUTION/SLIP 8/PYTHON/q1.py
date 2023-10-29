# Write a python script to find the repeated items of a tuple
def count(mytuple):
    s = set()
    for i in mytuple:
        if (mytuple.count(i) > 1):
            s.add(i)
    return s


n = int(input("Enter size of tuple: "))
print("Enter elements of tuple: ")
# Tgts
mylist = []
for i in range(n):
    tup_ele = input("enter:")
    mylist.append(tup_ele)
mytuple = tuple(mylist)
print(count(mytuple))
