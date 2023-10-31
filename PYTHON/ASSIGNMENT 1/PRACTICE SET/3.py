# Write python script to accept the x and y coordinate of a point and find the quadrant in which the point lies.
# // CPP program to check quadrant 
#include <bits/stdc++.h> 
x=int(input('Enter the values for X : '))
 
y=int(input('Enter the values for Y : '))

if x > 0 and y > 0:
  print ('x, y point lies in the First quandrant')
 
elif x < 0 and y > 0:
  print ('x, y point lies in the Second quandrant')
 
elif x < 0 and y < 0:
  print ('x, y point lies in the Third quandrant')

elif x > 0 and y < 0:
  print ('x, y point lies in the Fourth quandrant')

elif x == 0 and y == 0:
  print ('x, y point lies at the origin')