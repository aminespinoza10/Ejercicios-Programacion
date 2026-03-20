public class main {
    public static void main(String[] args) {
        long startTime = System.nanoTime();

        int iterations = 0;
        for (int y = -500; y < 500; y++)
            for (int x = -500; x < 500; x++) {
                double cr = x / 250.0, ci = y / 250.0;
                double zr = 0, zi = 0;
                for (int i = 0; i < 80; i++) {
                    double zr2 = zr*zr - zi*zi + cr;
                    zi = 2*zr*zi + ci;
                    zr = zr2;
                    if (zr*zr + zi*zi > 4) break;
                }
                iterations++;
            }

        long endTime = System.nanoTime();
        double elapsed = (endTime - startTime) / 1_000_000_000.0;
        System.out.printf("Time: %.4f seconds%n", elapsed);
        System.out.println("Points calculated: " + iterations);
    }
}
