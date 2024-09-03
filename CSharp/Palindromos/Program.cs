Console.WriteLine("Ejecución de aplicación");
Console.WriteLine("Ingresa por favor el número que quieres evaluar");
string receivedValue = Console.ReadLine();

List<int> firstList = PopulateFirstList(receivedValue);
List<int> secondList = PopulateSecondList(receivedValue);

var a = firstList.SequenceEqual(secondList);

if (a)
{
    Console.WriteLine("Tienes un palíndromo!");
}
else
{
    Console.WriteLine("Sigue intentando");
}

static List<int> PopulateFirstList(string receivedString)
{
    List<int> firstList = new List<int>();

    foreach (char item in receivedString)
    {
        string newCharacter = item.ToString();
        firstList.Add(Convert.ToInt32(newCharacter));
    }

    firstList.Reverse();
    return firstList;
}

static List<int> PopulateSecondList(string receivedString)
{
    List<int> secondList = new List<int>();

    foreach (char item in receivedString)
    {
        string newCharacter = item.ToString();
        secondList.Add(Convert.ToInt32(newCharacter));
    }

    return secondList;
}
