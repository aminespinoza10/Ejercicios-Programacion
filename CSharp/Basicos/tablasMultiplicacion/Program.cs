Console.WriteLine("Aplicación iniciada");
Console.WriteLine("Escribe el numero que vas a querer multiplicar");
int firstNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Escribe cuantas veces vas a querer multiplicarlo");
int secondNumber = Convert.ToInt16(Console.ReadLine());
CreateIteration(firstNumber, secondNumber);

static void CreateIteration(int rootNumber, int loopNumber)
{
    
    for (int i = 1; i < (loopNumber+1); i++)
    {
        int resultNumber = rootNumber * i;
        Console.WriteLine ($"{rootNumber} x {i} = {resultNumber}");
    }
}