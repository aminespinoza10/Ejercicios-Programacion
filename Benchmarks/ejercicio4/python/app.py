import json
import time

start = time.time()
data = [{"x": i, "y": str(i)} for i in range(2_000_000)]
s = json.dumps(data)
result = json.loads(s)
end = time.time()
elapsed = end - start
print(f"Time: {elapsed:.4f} seconds")
print(f"Items processed: {len(result)}")
print(f"JSON size: {len(s)} bytes")
