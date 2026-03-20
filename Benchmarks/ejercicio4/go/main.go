package main

import (
	"encoding/json"
	"fmt"
	"time"
)

func main() {
	start := time.Now()

	data := make([]map[string]interface{}, 2_000_000)
	for i := 0; i < len(data); i++ {
		data[i] = map[string]interface{}{"x": i, "y": fmt.Sprint(i)}
	}
	b, _ := json.Marshal(data)
	var out interface{}
	json.Unmarshal(b, &out)

	elapsed := time.Since(start).Seconds()
	fmt.Printf("Time: %.4f seconds\n", elapsed)
	fmt.Printf("Items processed: %d\n", len(data))
	fmt.Printf("JSON size: %d bytes\n", len(b))
}
