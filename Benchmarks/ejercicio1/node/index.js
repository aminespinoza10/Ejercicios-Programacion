function sieve(n) {
    const a = new Array(n + 1).fill(true);
    for (let i = 2; i * i <= n; i++) {
        if (a[i]) {
            for (let j = i * i; j <= n; j += i)
                a[j] = false;
        }
    }
    return a.filter((val, idx) => idx >= 2 && val).length;
}

const start = performance.now();
const primesCount = sieve(10_000_000);
const end = performance.now();
const elapsed = (end - start) / 1000;
console.log(`Time: ${elapsed.toFixed(4)} seconds`);
console.log(`Primes found: ${primesCount}`);
