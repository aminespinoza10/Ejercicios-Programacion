using System.Text;

//https://leetcode.com/problems/check-if-digits-are-equal-in-string-after-operations-i/description/
bool HasSameDigits(string s)
{
    while (s.Length > 2)
    {
        var newDigits = new StringBuilder();
        for (int i = 0; i < s.Length - 1; i++)
        {
            int sum = (s[i] - '0') + (s[i + 1] - '0');
            newDigits.Append(sum % 10);
        }
        s = newDigits.ToString();
    }
    return s[0] == s[1];
}

// Ejemplo de uso 1
string input = "3902";
bool result = HasSameDigits(input);
Console.WriteLine(result);

// Ejemplo de uso 2
string input2 = "34789";
bool result2 = HasSameDigits(input2);
Console.WriteLine(result2);


