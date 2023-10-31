# Write a recursive function to calculate sum of digits of a given input number.
def sum_of_digits(n):
    # Base case: if the number is a single digit, return the number
    if n < 10:
        return n
    else:
        # Recursive case: sum of the last digit and the sum of digits of the rest
        return n % 10 + sum_of_digits(n // 10)

# Example usage:
number = int(input("Enter a number for sum : "))
result = sum_of_digits(number)
print(f"The sum of digits of {number} is {result}")
