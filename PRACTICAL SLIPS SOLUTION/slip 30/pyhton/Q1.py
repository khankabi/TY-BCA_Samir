import tkinter as tk

def count_occurrences(string, character):
  count = 0
  for i in range(len(string)):
    if string[i] == character:
      count += 1
  return count

def main():
  root = tk.Tk()

  label = tk.Label(text="Enter a string:")
  label.pack()

  entry = tk.Entry()
  entry.pack()

  label = tk.Label(text="Enter a character:")
  label.pack()

  entry2 = tk.Entry()
  entry2.pack()

  button = tk.Button(text="Count Occurrences", command=lambda: print(count_occurrences(entry.get(), entry2.get())))
  button.pack()

  label = tk.Label(text="Number of occurrences:")
  label.pack()

  label = tk.Label(text=count_occurrences(entry.get(), entry2.get()))
  label.pack()

  root.mainloop()

if __name__ == "__main__":
  main()
