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

Console.WriteLine(GetArray(m, n));
//GetArray(array);

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    Random myRandom = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            result[i, j] = myRandom.NextDouble() * 100;
            Console.Write("{0,6:F2}", result[i, j]);
        }
        Console.WriteLine();
    }
    return result;
}
