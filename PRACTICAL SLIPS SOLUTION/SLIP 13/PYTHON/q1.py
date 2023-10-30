# Write a Python program to input a positive integer. Display correct message for correct and incorrect input. (Use Exception Handling)
try:
    num=int(input("Enter a positive number: "))
    if num<=0:
        raise Exception
    print(f"{num} is a positive number.")
    
except ValueError:
    print ("Invalid Input")
except Exception:
    print("You entered either Negative number or zero. Try again...")