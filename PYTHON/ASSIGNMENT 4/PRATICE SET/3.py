# Write an anonymous function to find area of circle.
import math
calculate_circle_area = lambda radius: math.pi * radius**2

# Example usage:
radius = float(input("Enter the radius of the circle: "))
area = calculate_circle_area(radius)
print(f"The area of the circle with radius {radius} is: {area}")
