import requests
import time

def main():
    url = "https://api.api-ninjas.com/v1/etf?ticker=SPY"
    headers = {
        "X-Api-Key": "kRa7NM9a8mXTcgSoB7hFJBGZNayCZurnZkIqc1Cq"
    }
    
    start_time = time.time()
    
    try:
        response = requests.get(url, headers=headers)
        response.raise_for_status()
        
        elapsed_time = time.time() - start_time
        
        print("Response:")
        print(response.json())
        print(f"\nTime taken: {elapsed_time:.4f} seconds")
        
    except requests.exceptions.RequestException as e:
        elapsed_time = time.time() - start_time
        print(f"Error: {e}")
        print(f"\nTime taken: {elapsed_time:.4f} seconds")

if __name__ == "__main__":
    main()
