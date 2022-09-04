/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/
Console.Clear();

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма четных чисел в промежутке от {m} до {n} = {SumNumber(m, n)}");


int SumNumber(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0)
        {
            return m + SumNumber(m + 2, n);
        }
        else
        {
            m++;
            return m + SumNumber(m + 2, n);
        }
    }
    else return 0;
}
