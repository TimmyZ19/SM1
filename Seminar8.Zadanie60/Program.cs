/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();

Console.WriteLine("Введете количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введете количество столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введете глубину массива");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] arrayMultidimensional = new int[rows, columns, depth];

Console.WriteLine("Массив 2x2x2: ");
GetArray3D(arrayMultidimensional);
PrintArray3D(arrayMultidimensional);

void GetArray3D(int[,,] arrayMultidimensional)
{
    for (int i = 0; i < arrayMultidimensional.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultidimensional.GetLength(1); j++)
        {
            for (int k = 0; k < arrayMultidimensional.GetLength(2); k++)
            {
                arrayMultidimensional[i, j, k] = new Random().Next(99);
            }
        }
    }
}

void PrintArray3D(int[,,] arrayMultidimensional)
{
    for (int i = 0; i < arrayMultidimensional.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultidimensional.GetLength(1); j++)
        {
            Console.Write("|  ");
            for (int k = 0; k < arrayMultidimensional.GetLength(2); k++)
            {
                Console.Write($"{arrayMultidimensional[i, j, k],2} ({i},{j},{k}) |  ");
            }
            Console.WriteLine();
        }
    }
}
