# Create a class circles having members radius. Use operator overloading to add the radius of two circle objects. Also display the area of circle.
class Circle:
  def __init__(self, radius):
    self.radius = radius

  def __add__(self, other):
    return Circle(self.radius + other.radius)

  def __repr__(self):
    return f"Circle({self.radius})"

  def area(self):
    return 3.14 * self.radius * self.radius

if __name__ == "__main__":
  c1 = Circle(3)
  c2 = Circle(4)

  print(c1 + c2)
  # Output: Circle(7)

  print(c1.area())
  # Output: 28.26
  print(c2.area())
  # Output: 50.26
