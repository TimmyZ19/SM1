/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99 && Number < 1000)
{
    Console.WriteLine((Number / 10) % 10);
}

else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
