# Write python script using package to calculate area and volume of cylinder and cuboids.
from geometry  import cylinder, cuboid

# Example for Cylinder
cylinder_radius = float(input("Enter the radius of the cylinder: "))
cylinder_height = float(input("Enter the height of the cylinder: "))

cylinder_area = cylinder.cylinder_surface_area(cylinder_radius, cylinder_height)
cylinder_vol = cylinder.cylinder_volume(cylinder_radius, cylinder_height)

print(f"\nCylinder Surface Area: {cylinder_area}")
print(f"Cylinder Volume: {cylinder_vol}")

# Example for Cuboid
cuboid_length = float(input("\nEnter the length of the cuboid: "))
cuboid_width = float(input("Enter the width of the cuboid: "))
cuboid_height = float(input("Enter the height of the cuboid: "))

cuboid_area = cuboid.cuboid_surface_area(cuboid_length, cuboid_width, cuboid_height)
cuboid_vol = cuboid.cuboid_volume(cuboid_length, cuboid_width, cuboid_height)

print(f"\nCuboid Surface Area: {cuboid_area}")
print(f"Cuboid Volume: {cuboid_vol}")
