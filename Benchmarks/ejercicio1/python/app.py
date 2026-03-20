import time

def sieve(n):
    a = [True] * (n + 1)
    for i in range(2, int(n**0.5) + 1):
        if a[i]:
            for j in range(i*i, n+1, i):
                a[j] = False
    return [i for i in range(2, n+1) if a[i]]

if __name__ == "__main__":
    start = time.time()
    result = sieve(10_000_000)
    end = time.time()
    elapsed = end - start
    print(f"Time: {elapsed:.4f} seconds")
    print(f"Primes found: {len(result)}")
