import time

class Node:
    def __init__(self, l=None, r=None):
        self.l = l
        self.r = r

def make_tree(d):
    if d == 0: return Node()
    return Node(make_tree(d-1), make_tree(d-1))

def count_nodes(node):
    if node is None: return 0
    if node.l is None and node.r is None: return 1
    return 1 + count_nodes(node.l) + count_nodes(node.r)

if __name__ == "__main__":
    start = time.time()
    tree = make_tree(18)
    end = time.time()
    elapsed = end - start
    nodes = count_nodes(tree)
    print(f"Time: {elapsed:.4f} seconds")
    print(f"Nodes created: {nodes}")
