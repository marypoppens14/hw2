// принимает на вход трёхзначное число 
// на выходе показывает вторую цифру этого числа

int a = Convert.ToInt32(Console.ReadLine());

string str = Convert.ToString(a);
Console.WriteLine($"Вторая цифра - {str[1]}");
