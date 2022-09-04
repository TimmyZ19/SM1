/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.(необязательная)
m = 2, n = 3 -> A(m,n) = 9
*/
Console.Clear();

Console.WriteLine("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительно число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}");

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 & n == 0)
    {
        return AkkermanFunction(m-1, 1);
    }
    else if (m > 0 & n > 0)
     {
        return AkkermanFunction(m-1, AkkermanFunction(m, n-1));
    }

    return 0;
}