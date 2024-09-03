Console.Write("Hola! Comencemos por recibir el primer número: ");
int numberOne = Convert.ToInt16(Console.ReadLine());
Console.Write("Ahora dame el segundo número: ");
int numberTwo = Convert.ToInt16(Console.ReadLine());
Console.Write("Vamos por el tercer número: ");
int numberThree = Convert.ToInt16(Console.ReadLine());
int operationResult = Multiplicate(numberOne, numberTwo, numberThree);
Console.WriteLine($"Tu resultado es {operationResult}");

int Multiplicate(int firstNumber, int secondNumber, int thirdNumber)
{
    int result = (firstNumber * secondNumber) * thirdNumber;
    return result;
}
