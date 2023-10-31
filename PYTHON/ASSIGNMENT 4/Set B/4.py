# Write a function which print a dictionary where the keys are numbers between 1 and 20
def print_number_dict():
    number_dict = {num: f"Value {num}" for num in range(1, 21)}
    for key,value in number_dict.items():
        print(f"{key}: {value}")

# Call the function to print the dictionary
print_number_dict()
