# Write a python script to generate Fibonacci terms using generator function.
def generate_fibonacci():
    a, b = 0, 1
    while True:
        yield a
        a, b = b, a + b

# Example usage:
num_terms = int(input("Enter the number of Fibonacci terms to generate: "))

fibonacci_generator = generate_fibonacci()

for _ in range(num_terms):
    print(next(fibonacci_generator))
