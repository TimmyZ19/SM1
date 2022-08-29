/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double[,] array = new double[2, 2];
double[] crossLineArray = new double[2];

void InputValuesEquation()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Введите значения для уравнения: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение k= ");
            else Console.Write($"Введите значение b= ");
            array[i, j] = Convert.ToUInt32(Console.ReadLine());
        }

    }
}

double[] Equation(double[,] array)
{
    crossLineArray[0] = (array[1,1] - array[0,1]) / (array[0,0] - array[1,0]);
    crossLineArray[1] = crossLineArray[0] * array[0,0] + array[0,1];
    return crossLineArray;
}

void FinalConclusions(double[,] array)
{
    Equation(array);
    Console.Write($"Точка пересечения двух прямых = ({crossLineArray[0]}, {crossLineArray[1]})");
}

InputValuesEquation();
FinalConclusions(array);