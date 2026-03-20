class Node {
    Node L, R;
    
    Node(Node l, Node r) {
        this.L = l;
        this.R = r;
    }
    
    Node() {
        this(null, null);
    }
}

public class main {
    static Node make(int d) {
        return d == 0 ? new Node() : new Node(make(d-1), make(d-1));
    }
    
    static int countNodes(Node node) {
        if (node == null) return 0;
        if (node.L == null && node.R == null) return 1;
        return 1 + countNodes(node.L) + countNodes(node.R);
    }
    
    public static void main(String[] args) {
        long startTime = System.nanoTime();
        Node tree = make(18);
        long endTime = System.nanoTime();
        double elapsed = (endTime - startTime) / 1_000_000_000.0;
        int nodes = countNodes(tree);
        System.out.printf("Time: %.4f seconds%n", elapsed);
        System.out.println("Nodes created: " + nodes);
    }
}
