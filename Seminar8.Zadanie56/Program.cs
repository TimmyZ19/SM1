/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();

Console.WriteLine("Введете количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

Console.WriteLine("Массив: ");
GetArray(array);
PrintArray(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSumElementsRowsArray(array)} ");


void GetArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random myRandom = new Random();
            array[i, j] = myRandom.Next(10);
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

int MinSumElementsRowsArray(int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0,i];
    }   
    for (int i = 1; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (minSum > sum)
            {
                minSum = sum;
                row = i;
            }

        }
   return row; 
}