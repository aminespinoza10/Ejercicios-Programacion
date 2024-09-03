using System;
using System.Collections.Generic;

namespace NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
 
            List<int> numbers = null;
            int? i = null;
 
            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);
 
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(i);
        }
    }
}
