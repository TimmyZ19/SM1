/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

Console.WriteLine("Введете количество строк массива 1: ");
int rowsArrayFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива 1: ");
int columnsArrayFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введете количество строк массива 2: ");
int rowsArraySecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива 2: ");
int columnsArraySecond = Convert.ToInt32(Console.ReadLine());

int[,] arrayFirst = new int[rowsArrayFirst, columnsArrayFirst];
int[,] arraySecond = new int[rowsArraySecond, columnsArraySecond];
int[,] arrayMulti = new int[rowsArrayFirst, columnsArraySecond];

Console.WriteLine("Исходный массив 1: ");
GetArray(arrayFirst);
PrintArray(arrayFirst);

Console.WriteLine("Исходный массив 2: ");
GetArray(arraySecond);
PrintArray(arraySecond);

Console.WriteLine("Произведение матриц: ");
ArrayMultiplication(arrayFirst, arraySecond, arrayMulti);
PrintArray(arrayMulti);


void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(100);
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

int[,] ArrayMultiplication(int[,] arrayFirst, int[,] arraySecond, int[,] arrayMulti)
{
    if (arrayFirst.GetLength(1) != arraySecond.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы!");
    }
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            arrayMulti[i, j] = 0;
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                arrayMulti[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }
    return arrayMulti;
}

