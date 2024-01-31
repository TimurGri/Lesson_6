//Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

using System;


class Program
{
    static string ReverseWords(string s)
    {
        string[] words = s.Split(' ');
        Array.Reverse(words);
        string result = string.Join(' ', words);
        return result;
    }
    static void Main(string[] args)
    {
        string s = "Важная строка с пробелами";
        string result = ReverseWords(s);
        Console.WriteLine($"Исходная строка: \"{s}\"");
        Console.WriteLine($"Строка с обратным порядком слов: \"{result}\"");
    }
}
