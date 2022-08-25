/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int SumOddElements(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sumOdd += array[i]; 
    }
    return sumOdd;
}

NumberArray(array);
Console.WriteLine($"Сумма нечетных элементов массива: {SumOddElements(array)}");