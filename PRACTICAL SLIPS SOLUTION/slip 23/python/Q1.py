# Write a Python GUI program to create a label and change the label font style (font name, bold, size) using tkinter module.
from tkinter import *
def change_font_style():
  label.config(font=("Times New Roman", 18, "bold"))
root = Tk()
root.geometry("200x200")
label = Label(root, text="Hello World!")
label.pack()
button = Button(root, text="Change Font Style", command=change_font_style)
button.pack()
root.mainloop()
