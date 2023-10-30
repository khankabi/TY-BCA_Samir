import tkinter as tk

def calculate_volume(radius):
  volume = (4/3) * 3.14 * radius * radius * radius
  return volume

def main():
  root = tk.Tk()

  label = tk.Label(text="Enter the radius of the sphere:")
  label.pack()

  entry = tk.Entry()
  entry.pack()

  button = tk.Button(text="Calculate Volume", command=lambda: print(calculate_volume(int(entry.get()))))
  button.pack()

  label = tk.Label(text="Volume of the sphere:")
  label.pack()

  label = tk.Label(text=calculate_volume(int(entry.get())))
  label.pack()

  root.mainloop()

if __name__ == "__main__":
  main()
