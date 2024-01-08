"""write a program to accept a number and count number of even,
odd,zero digits within that number."""

"""1. First way to do this
num=int(input("Enter a Number: "))
temp=num
even,odd,zero=0,0,0
while(temp>0):
    rem=temp%10
    if(rem==0):
        zero=zero+1        
    elif(rem%2!=0):
        odd=odd+1
    elif(rem%2==0):
        even=even+1        
    else:
        print("wrong input")
    temp=temp//10

print(f"Even : {even}\nOdd : {odd}\nZero : {zero}")
"""

""" 2. another way"""
def counter(n):
    odd=0
    even=0
    zero=0
    for i in n:
        if int(i) == 0:
            zero+=1
        elif int(i)%2==0:
            even+=1
        elif int(i)%2!=0:
            odd+=1
        else :
            print("wrong Number")
    print(f"Even : {even}\nOdd : {odd}\nZero : {zero}")

num=(input("Enter a number"))
counter(num)



















    
