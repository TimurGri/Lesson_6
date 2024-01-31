//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

Random rnd = new();
char[,] ch = new char[3, 3];
string str = "";
for (int i = 0; i < ch.GetLongLength(0); i++)
{
    for (int j = 0; j < ch.GetLength(1); j++)
    {
        ch[i, j] = (char)('a' + rnd.Next(0, 26));
    }
}
for (int i = 0; i < ch.GetLongLength(0); i++)
{
    for (int j = 0; j < ch.GetLength(1); j++)
    {
        str +=ch[i,j];
    }
}
Console.WriteLine(str);
