# write a python program to count the occurrences of each word in a given sentence.
str = input("Enter a string: ")

char_count = {}
for char in str:
    if char in char_count:
        char_count[char] += 1
    else:
        char_count[char] = 1

print(char_count)
