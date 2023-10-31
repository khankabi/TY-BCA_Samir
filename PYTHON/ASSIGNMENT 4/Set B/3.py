# Write a python script to accept decimal number and convert it to binary and octal number using function.
def decimal_to_binary(decimal_num):
    return bin(decimal_num)[2:]

def decimal_to_octal(decimal_num):
    return oct(decimal_num)[2:]

# Input decimal number from the user
decimal_number = int(input("Enter a decimal number: "))

# Convert to binary and octal using functions
binary_result = decimal_to_binary(decimal_number)
octal_result = decimal_to_octal(decimal_number)

# Display the results
print(f"Decimal Number: {decimal_number}")
print(f"Binary Equivalent: {binary_result}")
print(f"Octal Equivalent: {octal_result}")
