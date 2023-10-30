# Write Python GUI program that takes input string and change letter to upper case when a button is pressed.
import tkinter as tk
def change_to_uppercase():
  input_string = entry.get()
  output_string = input_string.upper()
  label.config(text=output_string)
root = tk.Tk()
entry = tk.Entry(root)
entry.pack()
button = tk.Button(root, text="Convert to uppercase", command=change_to_uppercase)
button.pack()
label = tk.Label(root)
label.pack()
root.mainloop()
