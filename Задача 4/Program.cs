/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введи 3 числа, чтобы узнать какое из них больше");
Console.WriteLine("Введи свое первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max;
max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;

Console.WriteLine($"Максимальное из этих чисел {max}");