Console.WriteLine("Ejecución de aplicación");
EvaluateExpression(1000);

static void EvaluateExpression(int desiredNumber)
{
    int a;

    for (a = 1; a <= desiredNumber / 3; a++)
    {
        int b;
        for (b = a + 1; b <= desiredNumber / 2; b++)
        {
            int c = desiredNumber - a - b;
            if (a * a + b * b == c * c)
            {
                Console.WriteLine($"{a}, {b}, {c}");
            }
        }
    }
}