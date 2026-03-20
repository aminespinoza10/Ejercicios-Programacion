import time

start = time.time()

iterations = 0
for y in range(-500, 500):
    for x in range(-500, 500):
        c = complex(x/250, y/250)
        z = 0
        for i in range(80):
            z = z*z + c
            if abs(z) > 2:
                break
        iterations += 1

end = time.time()
elapsed = end - start
print(f"Time: {elapsed:.4f} seconds")
print(f"Points calculated: {iterations}")
