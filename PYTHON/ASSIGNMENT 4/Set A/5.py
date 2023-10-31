# Write generator function which generate even numbers up to n
def generate_even_numbers(n):
    return (i for i in range(0, n + 1, 2))

# Example usage:
limit = 10
even_numbers = generate_even_numbers(limit)

for num in even_numbers:
    print(num)
