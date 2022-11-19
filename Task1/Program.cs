// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int randomNum = new Random().Next(100,1000);
Console.WriteLine(randomNum);
int num = (randomNum / 10 - randomNum / 100 * 10);
Console.WriteLine(num);
