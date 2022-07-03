// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше, либо равна 3 символам.

Console.Write("Введите что угодно с клавиатуры, через пробел  ");
string[] inputarray = Console.ReadLine().Split();

List<string> result = new List<string>();
foreach(string item in inputarray)
{
    if (item.Length < 4)
    {
        result.Add(item);
    }
}
Console.WriteLine(string.Join(" ", result));