//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

internal class Program
{
    private static void Main(string[] args)
    {

        char[,] GetRandom2DlowerCaseArray(int row, int col)
        {
            Random rnd = new();
            char[,] ch = new char[row, col];
            for (int i = 0; i < ch.GetLongLength(0); i++)
            {
                for (int j = 0; j < ch.GetLength(1); j++)
                {
                    ch[i, j] = (char)('a' + rnd.Next(0, 26));
                }
            }
            return ch;
        }

        void Print2DcharArray(char[,] ch)
        {
            for (int i = 0; i < ch.GetLongLength(0); i++)
            {
                for (int j = 0; j < ch.GetLength(1); j++)
                {
                    Console.Write(ch[i, j]);
                    if (j < ch.GetLength(1) - 1) Console.Write(", ");
                }
                Console.WriteLine();
            }
        }

        string Convert2DcharArrayToString(char[,] ch)
        {
            string str = "";
            for (int i = 0; i < ch.GetLength(0); i++)
            {
                for (int j = 0; j < ch.GetLength(1); j++)
                {
                    str += ch[i, j];
                }
            }
            return str;
        }

        Console.Write("Input the number of rows of char array: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the number of cols of char array: ");
        int col = Convert.ToInt32(Console.ReadLine());
        char[,] ch = GetRandom2DlowerCaseArray(row, col);
        string str = Convert2DcharArrayToString(ch);
        Print2DcharArray(ch);
        Console.WriteLine(str);


    }
}