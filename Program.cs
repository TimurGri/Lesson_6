//Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
string  str = Console.ReadLine();
string new_str = str.ToLower();
Console.WriteLine(new_str);