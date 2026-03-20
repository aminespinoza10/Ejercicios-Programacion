package main

import (
	"fmt"
	"time"
)

func main() {
	start := time.Now()

	n := 10_000_000
	a := make([]bool, n+1)
	for i := range a {
		a[i] = true
	}

	for i := 2; i*i <= n; i++ {
		if a[i] {
			for j := i * i; j <= n; j += i {
				a[j] = false
			}
		}
	}

	count := 0
	for i := 2; i <= n; i++ {
		if a[i] {
			count++
		}
	}

	elapsed := time.Since(start).Seconds()
	fmt.Printf("Time: %.4f seconds\n", elapsed)
	fmt.Printf("Primes found: %d\n", count)
}
