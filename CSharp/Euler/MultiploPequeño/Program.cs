int result = 1;
for (int i = 1; i <= 20; i++)
{
    result = LCM(result, i);
}
Console.WriteLine(string.Format("Tu resultado es {0}", result));

static int LCM(int a, int b)
{
    return (a / GCD(a, b)) * b;
}

static int GCD(int a, int b)
{
    while (b != 0)
    {
        int t = b;
        b = a % b;
        a = t;
    }
    return a;
}



