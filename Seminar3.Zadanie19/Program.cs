/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int palindrome = 0, num = number;

while (number > 0)
{
    palindrome = palindrome * 10 + number % 10;
    number /= 10;
}
if (num == palindrome)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}