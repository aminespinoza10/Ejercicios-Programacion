List<int> primesList = new List<int>();

Console.WriteLine("Ejecución de aplicación");
            
Console.Write("Tu resultado es: ");
Console.ForegroundColor = ConsoleColor.Cyan;
GetPrimes();
//Console.WriteLine(finalResult);

void GetPrimes()
{
    for (int i = 1; i < 2000000; i++)
    {
        if (isPrime(i))
        {
            primesList.Add(i);
        }
    }
    GetSumOfPrimes();
}

bool isPrime(int number)
{
    if (number == 1) return false;
    if (number == 2) return true;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 2; i <= boundary; ++i)
    {
        if (number % i == 0) return false;
    }

    return true;
}

void GetSumOfPrimes()
{
    int finalSum = 0;

    foreach (int item in primesList)
    {
        finalSum += item;
    }

    Console.WriteLine(finalSum);
}