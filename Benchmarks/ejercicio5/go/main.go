package main

import (
	"encoding/json"
	"fmt"
	"io"
	"net/http"
	"time"
)

func main() {
	url := "https://api.api-ninjas.com/v1/etf?ticker=SPY"
	apiKey := "kRa7NM9a8mXTcgSoB7hFJBGZNayCZurnZkIqc1Cq"

	startTime := time.Now()

	req, err := http.NewRequest("GET", url, nil)
	if err != nil {
		elapsed := time.Since(startTime).Seconds()
		fmt.Printf("Error creating request: %v\n", err)
		fmt.Printf("\nTime taken: %.4f seconds\n", elapsed)
		return
	}

	req.Header.Set("X-Api-Key", apiKey)

	client := &http.Client{}
	resp, err := client.Do(req)
	if err != nil {
		elapsed := time.Since(startTime).Seconds()
		fmt.Printf("Error making request: %v\n", err)
		fmt.Printf("\nTime taken: %.4f seconds\n", elapsed)
		return
	}
	defer resp.Body.Close()

	body, err := io.ReadAll(resp.Body)
	if err != nil {
		elapsed := time.Since(startTime).Seconds()
		fmt.Printf("Error reading response: %v\n", err)
		fmt.Printf("\nTime: %.4f seconds\n", elapsed)
		return
	}

	elapsed := time.Since(startTime).Seconds()

	fmt.Println("Response:")
	var result interface{}
	if err := json.Unmarshal(body, &result); err == nil {
		jsonData, _ := json.MarshalIndent(result, "", "  ")
		fmt.Println(string(jsonData))
	} else {
		fmt.Println(string(body))
	}

	fmt.Printf("\nTime taken: %.4f seconds\n", elapsed)
}
