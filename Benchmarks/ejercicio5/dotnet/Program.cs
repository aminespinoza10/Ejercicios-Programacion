using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;


var stopwatch = Stopwatch.StartNew();

using var client = new HttpClient();
client.DefaultRequestHeaders.Add("X-Api-Key", "kRa7NM9a8mXTcgSoB7hFJBGZNayCZurnZkIqc1Cq");

var response = await client.GetAsync("https://api.api-ninjas.com/v1/etf?ticker=SPY");
var content = await response.Content.ReadAsStringAsync();

stopwatch.Stop();

Console.WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds:F4} seconds");
Console.WriteLine($"Status: {(int)response.StatusCode}");
Console.WriteLine($"Response size: {content.Length} bytes");
Console.WriteLine("\nResponse body:");
Console.WriteLine(content);
