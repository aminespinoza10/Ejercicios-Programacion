List<int> multiples = new List<int>();

Console.WriteLine("Ejecución de aplicación");
IsNumberDivisible();
string finalResult = GetFinalSum();
Console.Write("Tu resultado es: ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(finalResult);


void IsNumberDivisible()
{
    for (int i = 1; i < 1000; i++)
    {
        if (i % 3 == 0)
        {
            multiples.Add(i);
        }
        if (i % 5 == 0)
        {
            multiples.Add(i);
        }
    }
}

string GetFinalSum()
{
    List<int> finalCleanList = multiples.Distinct().ToList();
    int finalNumber = 0;

    foreach (int item in finalCleanList)
    {
        finalNumber += item;
    }

    return finalNumber.ToString();
}
