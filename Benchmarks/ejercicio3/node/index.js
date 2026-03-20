class Node {
    constructor(l=null, r=null) { this.l = l; this.r = r; }
}

function makeTree(d) {
    if (d === 0) return new Node();
    return new Node(makeTree(d-1), makeTree(d-1));
}

function countNodes(node) {
    if (node === null) return 0;
    if (node.l === null && node.r === null) return 1;
    return 1 + countNodes(node.l) + countNodes(node.r);
}

const start = performance.now();
const tree = makeTree(18);
const end = performance.now();
const elapsed = (end - start) / 1000;
const nodes = countNodes(tree);
console.log(`Time: ${elapsed.toFixed(4)} seconds`);
console.log(`Nodes created: ${nodes}`);
