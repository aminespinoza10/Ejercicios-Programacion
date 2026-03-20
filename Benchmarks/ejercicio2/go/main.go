package main

import (
	"fmt"
	"time"
)

func main() {
	start := time.Now()

	iterations := 0
	for y := -500; y < 500; y++ {
		for x := -500; x < 500; x++ {
			cr, ci := float64(x)/250, float64(y)/250
			zr, zi := 0.0, 0.0
			for i := 0; i < 80; i++ {
				zr2 := zr*zr - zi*zi + cr
				zi = 2*zr*zi + ci
				zr = zr2
				if zr*zr+zi*zi > 4 {
					break
				}
			}
			iterations++
		}
	}

	elapsed := time.Since(start).Seconds()
	fmt.Printf("Time: %.4f seconds\n", elapsed)
	fmt.Printf("Points calculated: %d\n", iterations)
}
