using System;
using System.Diagnostics;

class Node {
    public Node? L, R;
    public Node(Node? l=null, Node? r=null) { L=l; R=r; }
}

class Program {
    static Node Make(int d) => d == 0 ? new Node() : new Node(Make(d-1), Make(d-1));
    
    static int CountNodes(Node? node) {
        if (node == null) return 0;
        if (node.L == null && node.R == null) return 1;
        return 1 + CountNodes(node.L) + CountNodes(node.R);
    }
    
    static void Main() {
        var stopwatch = Stopwatch.StartNew();
        var tree = Make(18);
        stopwatch.Stop();
        double elapsed = stopwatch.Elapsed.TotalSeconds;
        int nodes = CountNodes(tree);
        Console.WriteLine($"Time: {elapsed:F4} seconds");
        Console.WriteLine($"Nodes created: {nodes}");
    }
}

