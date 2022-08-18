/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int number)
{
    int sumNumber = 0;
    while (num > 0)
    {
        sumNumber += num % 10;
        num /= 10;
    }
    return sumNumber;
}

Console.WriteLine($"Сумма цифр в числе {num} = {SumOfNumbers(num)}");