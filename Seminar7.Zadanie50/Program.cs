/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();
Console.WriteLine("Введете количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X позиции элемента в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y позиции элемента в массиве: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

GetArray(array);
PrintArray(array);
PositionNumberInArray();

void GetArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random myRandom = new Random();
            array[i, j] = myRandom.Next(100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5:}", array[i, j]);
        }
        Console.WriteLine();

    }
}

void PositionNumberInArray()
{
    if (x > m && y > n)
        Console.WriteLine("Такого числа в массиве нет");
    else
    {
        object z = array.GetValue(x, y);
        Console.WriteLine();
        Console.WriteLine($"В массиве с координатами ({x},{y}) расположено значение: {z}");
    }
}

