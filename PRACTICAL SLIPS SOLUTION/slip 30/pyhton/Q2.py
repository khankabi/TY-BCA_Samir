class Country:
  def __init__(self, name):
    self.name = name

  def print_nationality(self):
    print("My nationality is", self.name)

class State(Country):
  def __init__(self, name, state):
    super().__init__(name)
    self.state = state

  def print_state(self):
    print("My state is", self.state)

def main():
  country = Country("India")
  country.print_nationality()

  state = State("India", "Punjab")
  state.print_state()
  state.print_nationality()

if __name__ == "__main__":
  main()
