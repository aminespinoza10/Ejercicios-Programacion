const start = performance.now();

let iterations = 0;
for (let y = -500; y < 500; y++)
    for (let x = -500; x < 500; x++) {
        let cr = x / 250, ci = y / 250;
        let zr = 0, zi = 0;
        for (let i = 0; i < 80; i++) {
            let zr2 = zr*zr - zi*zi + cr;
            zi = 2*zr*zi + ci;
            zr = zr2;
            if (zr*zr + zi*zi > 4) break;
        }
        iterations++;
    }

const end = performance.now();
const elapsed = (end - start) / 1000;
console.log(`Time: ${elapsed.toFixed(4)} seconds`);
console.log(`Points calculated: ${iterations}`);
