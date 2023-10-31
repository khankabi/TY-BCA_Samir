# Write a generator function which generates prime numbers up to n.
def generate_primes(n):
    primes = []
    num = 2
    while num <= n:
        is_prime = all(num % i != 0 for i in range(2, int(num**0.5) + 1))
        if is_prime:
            primes.append(num)
            yield num
        num += 1

# Example usage:
limit = int(input("Enter the value of n: "))
prime_generator = generate_primes(limit)

print(f"Prime numbers up to {limit}:")
for prime in prime_generator:
    print(prime)

