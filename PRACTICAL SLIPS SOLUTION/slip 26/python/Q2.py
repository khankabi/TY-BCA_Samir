# Write Python GUI program which accepts a sentence from the user and alters it when a button is pressed. Every space should be replaced by *, case of all alphabets should be reversed, digits are replaced by?.
import tkinter as tk

def convert_to_words(sentence):
  new_sentence = ""
  for i in range(len(sentence)):
    if sentence[i] == " ":
      new_sentence += "*"
    elif sentence[i].isalpha():
      new_sentence += sentence[i].upper()
    elif sentence[i].isdigit():
      new_sentence += "?"
    else:
      new_sentence += sentence[i]
  return new_sentence

def main():
  root = tk.Tk()

  label = tk.Label(text="Enter a sentence:")
  label.pack()

  entry = tk.Entry()
  entry.pack()

  button = tk.Button(text="Convert", command=lambda: print(convert_to_words(entry.get())))
  button.pack()

  root.mainloop()

if __name__ == "__main__":
  main()
