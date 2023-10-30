# Write a Python GUI program to calculate volume of Sphere by accepting radius as input.
from tkinter import *
def volumesphere():
    res=4.0/3.0*3.14*int(e1.get())**3
    label_text.set(res)
window=Tk()
label_text=StringVar()
Label(window,text="Enter Radius Number: ").grid(row=0)

Label(window,text="Result").grid(row=3)
result=Label(window,text="",textvariable=label_text).grid(row=3,column=1)
e1=Entry(window)
e1.grid(row=0,column=1)
b=Button(window,text="Calculate",command=volumesphere)
b.grid(row=0,column=2,columnspan=2,rowspan=2,padx=5,pady=5)
mainloop()