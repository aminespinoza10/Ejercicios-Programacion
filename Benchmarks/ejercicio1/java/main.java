import java.util.Arrays;

public class test {
    public static void main(String[] args) {
        long startTime = System.nanoTime();
        
        int n = 10_000_000;
        boolean[] a = new boolean[n + 1];
        Arrays.fill(a, true);

        for (int i = 2; i * i <= n; i++)
            if (a[i])
                for (int j = i * i; j <= n; j += i)
                    a[j] = false;
        
        int count = 0;
        for (int i = 2; i <= n; i++)
            if (a[i])
                count++;
        
        long endTime = System.nanoTime();
        double elapsed = (endTime - startTime) / 1_000_000_000.0;
        System.out.printf("Time: %.4f seconds%n", elapsed);
        System.out.println("Primes found: " + count);
    }
}
