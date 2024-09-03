package main

import (
    "fmt"
)

func GetMultiples() {
    firstList := []int{}
    finalMap := make(map[int]bool)
    finalValue := 0

    for counter := 0; counter < 1000; counter++ {
        if counter%3 == 0 {
            firstList = append(firstList, counter)
        }
        if counter%5 == 0 {
            firstList = append(firstList, counter)
        }
    }

    for _, value := range firstList {
        finalMap[value] = true
    }

    finalList := []int{}
    for key := range finalMap {
        finalList = append(finalList, key)
    }

    fmt.Println(finalList)

    for _, value := range finalList {
        finalValue += value
    }

    fmt.Println(finalValue)
}

func main() {
    GetMultiples()
}