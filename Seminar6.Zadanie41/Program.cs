/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите число M(кол-во чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void InputNumberArray(int[] array)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int SumPositiveNum(int[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 0) j++;
    }
    return j;
}

InputNumberArray(array);
Console.WriteLine($"Кол-во положительных чисел = {SumPositiveNum(array)}");

/*
Console.Write("Введите число M(кол-во чисел): ");
int m = Convert.ToInt32(Console.ReadLine());


int SumPositiveNum(int PosNum)
{
    int j = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) j++;
    }
    return j;
}
Console.WriteLine($"Кол-во положительных чисел = {SumPositiveNum(m)}");
*/