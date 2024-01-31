//Задайте произвольную строку. Выясните, является ли она палиндромом.
using System;


class Program
{
    static bool IsPalindrome(string s)
    {
        s = s.ToLower();
        s = s.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "");
        int n = s.Length;
        for (int i = 0; i < n / 2; i++)
        {
            if (s[i] != s[n - i - 1])
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        string s = "Аргентина манит негра";
        bool result = IsPalindrome(s);
        Console.WriteLine($"Строка \"{s}\" {(result ? "является" : "не является")} палиндромом.");
    }
}