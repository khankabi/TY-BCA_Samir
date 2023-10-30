#  Define a class named Rectangle which can be constructed by a length and width. The Rectangle class has a method which can compute the area and Perimeter.
class Rectangle():
    def __init__(self, l, w):
        self.length = l
        self.width  = w
    def rectangle_area(self):
        area=self.length*self.width
        perimeter=2*(self.length+self.width)
        return area,perimeter
newRectangle = Rectangle(12, 10)
result=newRectangle.rectangle_area()
print("Area: ",result[0])
print("Perimeter: ",result[1])
