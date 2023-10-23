# Write python script using package to calculate area and volume of cube and sphere
# from Calc import area_sphere
# from Calc import vol_sphere
# from Calc import area_cube
# from Calc import vol_cube
from Calc import *

radius=int(input("Enter radius of sphere: "))
sphere_area=area_sphere(radius)
sphere_vol=vol_sphere(radius)
print(f"Area of sphere: {sphere_area}\nVolume of sphere: {sphere_vol}\n\n")
side=int(input("Enter side of cube: "))
cube_area=area_cube(side)
cube_vol=vol_cube(side)
print(f"Area of cube: {cube_area}\nVolume of cube:{cube_vol}")



# from Calc import functions

# radius=int(input("Enter radius of sphere: "))
# sphere_area=functions.area_sphere(radius)
# sphere_vol=functions.vol_sphere(radius)
# print(f"Area of sphere: {sphere_area}\nVolume of sphere: {sphere_vol}\n\n")
# side=int(input("Enter side of cube: "))
# cube_area=functions.area_cube(side)
# cube_vol=functions.vol_cube(side)
# print(f"Area of cube: {cube_area}\nVolume of cube:{cube_vol}")