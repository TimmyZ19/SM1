/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void NumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random myRandom = new Random();
        array[i] = myRandom.Next(100);
        Console.Write($"{array[i]} ");
    }

}

int DiffBetweenMinAndMaxInArray(int[] array)
{
    int minNum = array[0];
    int maxNum = array[0];
    for (int i=0; i < array.Length; i++)
    {
        if (maxNum < array[i]) 
        maxNum = array[i];
        if (minNum > array[i])
        minNum = array[i];
    }
return maxNum - minNum;

}
NumberArray(array);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементами массива: {DiffBetweenMinAndMaxInArray(array)}");