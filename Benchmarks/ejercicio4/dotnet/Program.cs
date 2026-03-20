using System;
using System.Diagnostics;
using System.Text.Json;

var stopwatch = Stopwatch.StartNew();

var data = new List<object>();
for (int i = 0; i < 2_000_000; i++)
    data.Add(new { x = i, y = i.ToString() });

string s = JsonSerializer.Serialize(data);
var result = JsonSerializer.Deserialize<object>(s);

stopwatch.Stop();
double elapsed = stopwatch.Elapsed.TotalSeconds;
Console.WriteLine($"Time: {elapsed:F4} seconds");
Console.WriteLine($"Items processed: {data.Count}");
Console.WriteLine($"JSON size: {s.Length} bytes");
