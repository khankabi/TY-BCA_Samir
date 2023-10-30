import tkinter as tk

def convert_to_binary(num):
  binary = bin(num).replace("0b", "")
  return binary

def convert_to_octal(num):
  octal = oct(num).replace("0o", "")
  return octal

def convert_to_hexadecimal(num):
  hexadecimal = hex(num).replace("0x", "")
  return hexadecimal

def main():
  root = tk.Tk()

  label = tk.Label(text="Enter a decimal number:")
  label.pack()

  entry = tk.Entry()
  entry.pack()

  button = tk.Button(text="Convert", command=lambda: print(convert_to_binary(int(entry.get()))))
  button.pack()

  label = tk.Label(text="Binary:")
  label.pack()

  label = tk.Label(text=convert_to_binary(int(entry.get())))
  label.pack()

  button = tk.Button(text="Convert to octal", command=lambda: print(convert_to_octal(int(entry.get()))))
  button.pack()

  label = tk.Label(text="Octal:")
  label.pack()

  label = tk.Label(text=convert_to_octal(int(entry.get())))
  label.pack()

  button = tk.Button(text="Convert to hexadecimal", command=lambda: print(convert_to_hexadecimal(int(entry.get()))))
  button.pack()

  label = tk.Label(text="Hexadecimal:")
  label.pack()

  label = tk.Label(text=convert_to_hexadecimal(int(entry.get())))
  label.pack()

  root.mainloop()

if __name__ == "__main__":
  main()
