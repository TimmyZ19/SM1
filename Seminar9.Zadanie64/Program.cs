/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/
Console.Clear();

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Number(m, n);

void Number(int m, int n)
{
    if (m == n)
    {
        Console.Write(m + " ");
        return;
    }
    else if (m > n)
    {
        Number(m - 1, n);
        Console.Write(m + " ");
    }
    else
    {
        Number(m + 1, n);
        Console.Write(m + " ");
    }
}