/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите день недели(цифра): ");
int NumberDay = Convert.ToInt32(Console.ReadLine());


if (NumberDay > 0 && NumberDay < 8)
{
    Console.WriteLine($"День недели {NumberDay}. Выходной?");
    if (NumberDay > 5)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Введите корректный день недели");
}
