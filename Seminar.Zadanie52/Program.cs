/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
Console.WriteLine("Введете количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
//double[] columnsArray = new double[n];

GetArray(array);
PrintArray(array);
ArithmeticMeanOfTheColumn(array);

void GetArray(double[,] array)
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

void PrintArray(double[,] array)
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

void ArithmeticMeanOfTheColumn(double[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summa += array[i,j];
        }
        double avg = summa / m;
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {avg}");

    }
}