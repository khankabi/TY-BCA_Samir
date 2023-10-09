'''
2)Write a Python program to do iteration over sets
'''
#Create a set 
num_set = set([0, 1, 2, 3, 4, 5])
for n in num_set:
  print(n, end=' ')
print("\n\nCreating a set using string:")
char_set = set("PythonProgram")  
# Iterating using for loop
for val in char_set:
    print(val, end=' ')
