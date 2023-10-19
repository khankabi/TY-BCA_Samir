#write a python GUI program to create a digital clock with tkinter to display the time
from tkinter import * 
from tkinter.ttk import *  
# import strftime function to retrieve system's time 
from time import strftime   
# creating tkinter window 
main = Tk() 
main.title('Clock') 
main.geometry("700x500")  
# This function is used to  
# display time on the label 
def time(): 
    string = strftime('%H:%M:%S %p') 
    lbl.config(text = string) 
    lbl.after(1000, time)   
# Styling the label widget so that clock 
# will look more attractive 
lbl = Label(main, font = ('calibri', 40, 'bold'), foreground = 'black')   
# Placing clock at the centre 
# of the tkinter window 
lbl.pack(anchor = 'center') 
time()   
mainloop()