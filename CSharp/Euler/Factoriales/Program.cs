Console.WriteLine("Ejecución de aplicación");
SearchFactorial(600851475143);

static void SearchFactorial(long evaluatedNumber)
{
    long k = 2;
    while (k * k <= evaluatedNumber)
    {
        if (evaluatedNumber % k == 0)
        {
            evaluatedNumber /= k;
        }
        else
        {
            ++k;
        }
    }

    Console.Write("Tu resultado es: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(evaluatedNumber);
}