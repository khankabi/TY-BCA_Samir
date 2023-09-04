#C:\Users\Pc11\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\GitHub, Inc
"""write a python script which accept 5 integer values and prints "DUPLICATES" if any of the values
entered are duplicates otherwise it prints "ALL UNIQUE". Example: let 5 integers are (32,45,90,45,6)
then output "DUPLICATES" to be printed"""
List2 = list()
for i in range(5):
    List2.append(int(input("Enter : ")))
print(List2)
print(set(List2))
if (len(set(List2)))!=len(List2):
    print("duplicates")
else:
    print("unique")

    

    
