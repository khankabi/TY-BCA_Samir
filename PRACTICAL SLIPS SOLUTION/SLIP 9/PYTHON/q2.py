# Write Python GUI program to accept a number n and check whether it is Prime, Perfect or Armstrong number or not. Specify three radio buttons.
from tkinter import *
root=Tk()

radio = IntVar()
canvas1 = Canvas (root, width = 400, height = 300)
canvas1.pack()
entry1 = Entry (root)
canvas1.create_window(200, 140, window=entry1)

def getprime (): 
    n = int(entry1.get())

    if n > 1:

        for i in range(2, n):

             if (n % i) == 0:
                 txt = (n, "is not a prime number")
                 break

    else:
        txt=(n,"is prime number")
    label1=Label(root,text=txt)
    canvas1.create_window(200,250,window=label1)

def getarmstrong():
    n=int(entry1.get())
    temp=n 
    sum=0

    while temp>0:
        digit = temp % 10
        sum +=digit**3
        temp //=10

    if n == sum:
        txt= (n,"is a an armstrong number")
    else:
        txt=(sum,"is not an armstrong number")
    label1=Label(root,text=txt)
    canvas1.create_window(200,250,window=label1)


def getperfect():
    n= int(entry1.get())
    sum=0

    for i in range(1,n):
        if n%i==0:
            sum=sum+i

    if sum==n:
        txt=(n,"is perfect number")
    else:
        txt=(n,"is not perfect number")
    label1=Label(root,text=txt)
    canvas1.create_window(200,250,window=label1)

button1=Radiobutton(canvas1,text="Prime",variable=radio,value=3,command=getprime)
button2=Radiobutton(canvas1,text="Armstrong",variable=radio,value=2,command=getarmstrong)
button3=Radiobutton(canvas1,text="Perfect",variable=radio,value=1,command=getperfect)

canvas1.create_window(200,180,window=button1)
canvas1.create_window(200,200,window=button2)
canvas1.create_window(200,220,window=button3)

root.mainloop()
