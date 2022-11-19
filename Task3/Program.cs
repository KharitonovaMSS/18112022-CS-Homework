
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру порядковый номер дня недели (1-7): ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
Console.WriteLine("Нет");
}
else
{
Console.WriteLine("Да");
}

if(num > 7 || num < 1)
{
    Console.WriteLine("Некорректнфй номер, введите от 1 до 7");
}