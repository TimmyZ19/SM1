/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int Number1 = new int();
int Number2 = new int();

Console.WriteLine("Введите первое число");
Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
    Console.WriteLine($"Большее число = {Number1}. Меньшее число = {Number2}.");
}
else
{
    Console.WriteLine($"Большее число = {Number2}. Меньшее число = {Number1}.");
}