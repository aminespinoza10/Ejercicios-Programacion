const start = performance.now();
const data = Array.from({length: 2_000_000}, (_, i) => ({x: i, y: String(i)}));
const s = JSON.stringify(data);
const result = JSON.parse(s);
const end = performance.now();
const elapsed = (end - start) / 1000;
console.log(`Time: ${elapsed.toFixed(4)} seconds`);
console.log(`Items processed: ${result.length}`);
console.log(`JSON size: ${s.length} bytes`);
