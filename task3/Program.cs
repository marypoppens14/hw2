// принимает на вход цифру, обозначающую день недели
// проверяет, является ли этот день выходным 

int a = Convert.ToInt32(Console.ReadLine());

if (a > 1 && a < 6)
{
    Console.WriteLine("Рабочий день");
}
    
else if (a == 6 || a == 7)
{
    Console.WriteLine("Выходной день");
}
    
else
{
    Console.WriteLine("Такого дня недели нет");
}