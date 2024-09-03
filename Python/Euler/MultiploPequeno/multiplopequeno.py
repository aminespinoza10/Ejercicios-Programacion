def LCM(a, b):
    return (a / GCD(a, b))* b

def GCD(a, b):
    while b != 0:
        t = b
        b = a % b
        a = t
    return a

result = 1
for i in range(1, 20):
    result = LCM(result, i)

print("Tu resultado es:" + str(result))