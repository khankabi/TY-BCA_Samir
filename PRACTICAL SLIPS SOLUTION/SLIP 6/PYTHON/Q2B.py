# Write a Python GUI program to create a label and change the label font style (font name, bold, size). 
# Specify separate check button for each style.
from tkinter import *
win= Tk()

win.geometry("650x250")
def size_1():
    text.config(font=('Arial',20))
    text.config(bg="gray51", fg="white")
def size_2():
    text.config(font=('Helvetica bold',40))
    text.config(bg= "white", fg= "red")
text=Label(win, text="Hello World!")
text.pack()
frame= Frame(win)


#Create a label
Label (frame, text="Select the Font-Size").pack()
#Create Buttons for styling the label
button1=Checkbutton(frame, text="Arial - 20",command=size_1)
button1.pack(pady=10)
button2= Checkbutton(frame, text="Helvetica - 40", command=size_2)
button2.pack(pady=10)
frame.pack()
win.mainloop()