/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();

Console.WriteLine("Введете количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

GetArrayDouble(array);
PrintArray(array);
Console.WriteLine();

void GetArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random myRandom = new Random();
            array[i, j] = myRandom.NextDouble() * 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
}