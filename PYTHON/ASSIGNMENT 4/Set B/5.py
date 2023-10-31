# (both included) and the values are square of keys
def print_number_dict():
    number_dict = {num: num**2 for num in range(1, 21)}
    for key,value in number_dict.items():
        print(f"{key}: {value}")

# Call the function to print the dictionary
print_number_dict()

