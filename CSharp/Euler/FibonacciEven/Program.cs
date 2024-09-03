int result = 0;

int fibonacci_1 = 1;
int fibonacci_2 = 1;

while (fibonacci_1 <= 4000000)
{
    if (fibonacci_1 % 2 == 0)
    {
        result += fibonacci_1;
    }
    int fb_2Aux = fibonacci_1;
    fibonacci_1 = fibonacci_2 + fibonacci_1;
    fibonacci_2 = fb_2Aux;
}

Console.Write("Tu resultado es: " );
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(result);