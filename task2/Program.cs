// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);

if (b.Length > 2)
{
    Console.WriteLine($"Третья цифра числа - {b[2]}");
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}
