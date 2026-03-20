package main

import (
	"fmt"
	"time"
)

type Node struct{ L, R *Node }

func makeTree(d int) *Node {
	if d == 0 {
		return &Node{}
	}
	return &Node{makeTree(d - 1), makeTree(d - 1)}
}

func countNodes(node *Node) int {
	if node == nil {
		return 0
	}
	if node.L == nil && node.R == nil {
		return 1
	}
	return 1 + countNodes(node.L) + countNodes(node.R)
}

func main() {
	start := time.Now()
	tree := makeTree(18)
	elapsed := time.Since(start).Seconds()
	nodes := countNodes(tree)
	fmt.Printf("Time: %.4f seconds\n", elapsed)
	fmt.Printf("Nodes created: %d\n", nodes)
}
