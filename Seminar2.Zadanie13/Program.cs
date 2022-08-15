/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99)
{
    while (Number > 999)
    {
        Number = Number / 10;
    }
    Console.WriteLine(Number % 10);
}

else
{
    Console.WriteLine("В введенном числе нет третьей цифры");
}