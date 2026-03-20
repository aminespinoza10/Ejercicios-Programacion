using System;
using System.Diagnostics;

class Program {
    static void Main() {
        var stopwatch = Stopwatch.StartNew();
        
        int n = 10_000_000;
        bool[] a = new bool[n + 1];
        Array.Fill(a, true);

        for (int i = 2; i * i <= n; i++)
            if (a[i])
                for (int j = i * i; j <= n; j += i)
                    a[j] = false;
        
        int count = 0;
        for (int i = 2; i <= n; i++)
            if (a[i])
                count++;
        
        stopwatch.Stop();
        double elapsed = stopwatch.Elapsed.TotalSeconds;
        Console.WriteLine($"Time: {elapsed:F4} seconds");
        Console.WriteLine($"Primes found: {count}");
    }
}
