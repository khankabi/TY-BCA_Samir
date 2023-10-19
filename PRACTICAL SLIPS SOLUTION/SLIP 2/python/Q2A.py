# write a python function that accept a string and calculate the number of uppercase letters and
#  lowercase letters.

def countcase(str):
    upper,lower=0,0 #counter variable
    for i in str:
        if(i.isupper()==True):
            upper+=1
        elif(i.islower()==True):
            lower+=1
        else:
            print("Wrong Input")
            break 
    print(" No. of Upper case characters: ",upper)
    print(" No. of Lower case characters: ",lower)
#Tgts
str=input("Enter string: ")
countcase(str)