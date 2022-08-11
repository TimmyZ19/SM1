/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int Number1 = new int();
int Number2 = new int();
int Number3 = new int();

Console.WriteLine("Введите первое число");
Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
Number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
Number3 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
    if (Number1 > Number3)
    {
        Console.WriteLine($"Максимальное число = {Number1}");
    }
    else
        Console.WriteLine($"Максимальное число = {Number3}");
}
else
if (Number2 > Number3)
{
    Console.WriteLine($"Максимальное число = {Number2}");
}
else
    Console.WriteLine($"Максимальное число = {Number3}");


