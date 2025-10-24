def two_sum(nums, target):
    num_map = {}
    for i, num in enumerate(nums):
        complement = target - num
        if complement in num_map:
            return [num_map[complement], i]
        num_map[num] = i
    return []

# Ejemplo de uso 1
print(two_sum([2, 7, 11, 15], 9))

# Ejemplo de uso 2
print(two_sum([3, 2, 4], 6))