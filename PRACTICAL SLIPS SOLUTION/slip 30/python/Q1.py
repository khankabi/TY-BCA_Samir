# Write a Python GUI program to accept a string and a character from user and count the occurrences of a character in a string.
from tkinter import *
def volumesphere():
    count=0
    for i in range (len(string.get())):
        if(string.get()[i]==char.get()):
            count=count+1
        label_text.set(count)
window=Tk()
label_text=StringVar()
Label(window,text="Enter String : ").grid(row=0)
Label(window,text="Enter Your charcter : ").grid(row=1)
Label(window,text="the total number of times has occurred String : ").grid(row=3)
result=Label(window,text="",textvariable=label_text).grid(row=3,column=1)
string=Entry(window)
string.grid(row=0,column=1)
char=Entry(window)
char.grid(row=1,column=1)
b=Button(window,text="Calculate",command=volumesphere)
b.grid(row=0,column=2,columnspan=2,rowspan=2,padx=5,pady=5)
mainloop()