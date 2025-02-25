using System.Text.RegularExpressions;

Console.Write("Введите строку: ");
string record = Console.ReadLine();
Console.WriteLine($"Количество символов: {record.Length}");
Console.WriteLine($"Количество символов без учета пробела: {record.Replace(" ","").Length}");

int count = 0;

for (int i = 0; i < record.Length; i++)
{
    if (char.IsLetter(record[i]))
        count++;
}
Console.WriteLine($"Количество букв: {count}");

Console.Write("Введите символ: ");
char symbol = Convert.ToChar(Console.ReadLine());
bool isFind = true;

for (int i = 0;i < record.Length;i++)
{
    if(symbol == record[i])
    {
        Console.WriteLine(i);
        isFind = false;
    } 
}
if (isFind)
    Console.WriteLine("Совпадение не найдено");
Console.WriteLine(record.Trim()/*.Replace(\record{2,}, "")*/);
RegexOptions options = RegexOptions.None;
Regex regex = new Regex("[ ]{2,}", options);
record = Regex.Replace(record, @" {2,}", ""); re