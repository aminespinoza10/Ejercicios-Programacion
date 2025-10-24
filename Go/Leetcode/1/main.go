package main

import (
    "fmt"
)

func TwoSum(nums []int, target int) []int {
    numMap := make(map[int]int)
    for i, num := range nums {
        complement := target - num
        if j, found := numMap[complement]; found {
            return []int{j, i}
        }
        numMap[num] = i
    }
    return nil
}


func main() {
    // Ejemplo de uso 1
	nums1 := []int{2, 7, 11, 15}
	target1 := 9
	result1 := TwoSum(nums1, target1)
	fmt.Printf("Output: %v\n", result1)

    // Ejemplo de uso 2
    nums2 := []int{3, 2, 4}
	target2 := 6
	result2 := TwoSum(nums2, target2)
	fmt.Printf("Output: %v\n", result2)
}
