# Write Python GUI program to add items in listbox widget and to print and delete the selected items from listbox on button click. Provide three separate buttons to add, print and delete.
from tkinter import *

def add_item():
  # Get the text from the entry widget
  text = entry.get()

  # Add the text to the listbox widget
  listbox.insert(END, text)

  # Clear the entry widget
  entry.delete(0, END)

def print_item():
  # Get the selected items from the listbox widget
  selected_items = listbox.get(0, END)

  # Print the selected items
  for item in selected_items:
    print(item)

def delete_item():
  # Get the selected items from the listbox widget
  selected_items = listbox.get(0, END)

  # Delete the selected items from the listbox widget
  for item in selected_items:
    listbox.delete(item)

# Create the main window
root = Tk()

# Create the entry widget
entry = Entry(root)

# Create the listbox widget
listbox = Listbox(root)

# Create the buttons
add_button = Button(root, text="Add Item", command=add_item)
print_button = Button(root, text="Print Item", command=print_item)
delete_button = Button(root, text="Delete Item", command=delete_item)

# Place the widgets
entry.pack()
listbox.pack()
add_button.pack()
print_button.pack()
delete_button.pack()

# Start the main loop
root.mainloop()
