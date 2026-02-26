bool IsPalindrome(int x) {
    if (x < 0 || (x % 10 == 0 && x != 0))
        return false;
    
    int rev = 0;

    while (rev < x){
        Console.WriteLine($"Valor de rev: {rev}, Valor de x: {x}");
        rev = rev * 10 + x % 10;
        x /= 10;
    }
    return x == rev || x == rev / 10;
}

Console.WriteLine("Probando con los casos de prueba:");
Console.WriteLine(" Es Palindromo(121): " + IsPalindrome(121));
Console.WriteLine(" Es Palindromo(-121): " + IsPalindrome(-121));
Console.WriteLine(" Es Palindromo(10): " + IsPalindrome(10)); 
