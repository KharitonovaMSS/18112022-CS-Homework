// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();

if(num.Length >= 3)
{
Console.WriteLine($"{num[2]}");
}
else
{
  Console.WriteLine("Нет третьего числа");
}
