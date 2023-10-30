# Write a Python GUI program to accept a number form user and display its multiplication table on button click.
import tkinter as tk

def generate_table():
  number = int(entry.get())
  for i in range(1, 11):
    print(number, "x", i, "=", number * i)

root = tk.Tk()
root.title("Multiplication Table Generator")

label = tk.Label(text="Enter a number:")
label.pack()

entry = tk.Entry()
entry.pack()

button = tk.Button(text="Generate Table", command=generate_table)
button.pack()

root.mainloop()
