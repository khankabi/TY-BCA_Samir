# Write a Python GUI program to accept dimensions of a cylinder and display the surface area and volume of cylinder.
from tkinter import *

 

def volume():

   

    res= 3.14*int(r1.get())*int(r1.get())*int(h1.get())

    myText.set(res)

 

def  sur_area():

     sur_area = (2*3.14*int(r1.get()) * int(h1.get())) + ((3.14*int(r1.get())**2)*2)

     myText1.set(sur_area )

    

master = Tk()

master.geometry('500x300')

myText=StringVar()

myText1=StringVar()

 

Label(master, text="Height of cylinder").grid(row=0)

Label(master, text="Radius of cylinder").grid(row=1)

 

Label(master, text="Volume:").grid(row=3)

Label(master, text="sur_area:").grid(row=4)

  

result=Label(master, text="", textvariable=myText).grid(row=3,column=1)

result1=Label(master, text="", textvariable=myText1).grid(row=4,column=1)

  

r1 = Entry(master)

h1 = Entry(master)

 

r1.grid(row=0, column=1)

h1.grid(row=1, column=1)

 

b = Button(master, text="Volume", command=volume)

b.grid(row=0, column=2,columnspan=2, rowspan=2, padx=5, pady=5)

 

c = Button(master, text="Sur_area", command=sur_area)

c.grid(row=3, column=2,columnspan=2, rowspan=2,padx=5, pady=5)

   

  

mainloop()