class StringRepetition:

  def __init__(self, string, number):
    self.string = string
    self.number = number

  def __repr__(self):
    return self.string * self.number

if __name__ == "__main__":
  string = input("Enter a string: ")
  number = int(input("Enter a number: "))

  string_repetition = StringRepetition(string, number)
  print(string_repetition)
