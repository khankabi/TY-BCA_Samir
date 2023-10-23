#  Write python script using package to calculate area and volume of cube and sphere
pi=3.14
def area_sphere(r):
    global pi
    return 4*pi*r*r

def vol_sphere(r):
    global pi
    return 4/3*pi*(r*r*r)

def area_cube(s):
    return 6*s*s

def vol_cube(s):
    return s*s*s