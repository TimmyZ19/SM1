/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void ThreeDigitNumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random myRandom = new Random();
        array[i] = myRandom.Next(100, 1000);
        Console.Write($"{array[i]} ");
    }

}

int QualityPositiveNumbers(int[] array)
{
    int quality = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quality++;
        }

    }
   // Console.WriteLine($"Кол-во положительных чисел в массиве: {quality}");
   return quality;
}
ThreeDigitNumberArray(array);
//QualityPositiveNumbers(array);
Console.WriteLine();
Console.WriteLine($"Кол-во положительных чисел в массиве: {QualityPositiveNumbers(array)}");

