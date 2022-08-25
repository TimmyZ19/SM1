/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Degree(int numberA, int numberB)
{
    int deg = numA;
    for (int i = 1; i < numB; i++)
    {
        deg *= numA;
    }
    return deg;
}

Console.WriteLine($"Число {numA} в степени {numB} = {Degree(numA, numB)}");

// double Degree(double numberA, double numberB)
// {
//     double deg = Math.Pow(numA, numB);
//     return deg;
// }

// Console.WriteLine($"Число {numA} в степени {numB} = {Degree(numA, numB)}");