#write a python script to count the number of charcters (charcter frequency) in a string.
#sample string: google.com . expected result :{'o':3,'g':2,'.':1,'e':1,'i':1,'m':1,'c':1}
str= input("Enter the string : ")
d=dict()
for char in str:
    if char in d:
        d[char]=d[char]+1
    else:
        d[char]=1
for key,value in d.items():
    print(key," ",value)
    
