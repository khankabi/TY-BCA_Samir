import tkinter as tk

def convert_to_words(num):
  ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
  tens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"]

  if num == 0:
    return "zero"

  result = ""
  while num > 0:
    hundreth = num // 100
    num %= 100
    tenth = num // 10
    unit = num % 10

    result += ones[unit]
    if tenth > 0:
      result += " " + tens[tenth]
    if hundreth > 0:
      result += " " + ones[hundreth] + " hundred"

    num //= 100

  return result

def main():
  root = tk.Tk()

  # Create an entry widget for entering the number
  entry = tk.Entry(root)
  entry.pack()

  # Create a label widget for displaying the result
  label = tk.Label(root)
  label.pack()

  # Create a button widget for converting the number to words
  button = tk.Button(root, text="Convert", command=lambda: label.config(text=convert_to_words(int(entry.get()))))
  button.pack()

  root.mainloop()

if __name__ == "__main__":
  main()
