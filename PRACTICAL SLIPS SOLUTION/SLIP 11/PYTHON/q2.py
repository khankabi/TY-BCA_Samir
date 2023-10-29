# Write Python GUI program to add menu bar with name of colors as options to change the background color as per selection from menu option.
from tkinter import *
window = Tk()
window.title("Menu bar")
window.geometry("400x300")
# window background colors
def bgred():
    window.config(bg="red")
def bgyellow():
    window.config(bg="yellow")
def bggreen():
    window.config(bg="green")

# menu bar background colors
def mred():
    BG_Menu_Colors.config(background="red",fg="white")
def myellow():
   BG_Menu_Colors.config(background="yellow",fg="black")
def mgreen():
   BG_Menu_Colors.config(background="green",fg="blue")



menubar = Menu(window,background="yellow",fg="black")

BG_Colors= Menu(menubar,tearoff=False)
BG_Menu_Colors= Menu(menubar,tearoff=False)

BG_Colors.add_command(label = "Red",command=bgred)
BG_Colors.add_command(label = "Yellow",command=bgyellow)
BG_Colors.add_command(label = "Green",command=bggreen)

BG_Menu_Colors.add_command(label = "Red",command=mred)
BG_Menu_Colors.add_command(label = "Yellow",command=myellow)
BG_Menu_Colors.add_command(label = "Green",command=mgreen)

menubar.add_cascade(label = "BG_Colors",menu= BG_Colors)
menubar.add_cascade(label = "BG_Menu_Colors",menu= BG_Menu_Colors)

window.config(menu=menubar)
window.mainloop()