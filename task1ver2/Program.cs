// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Ввведите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 10000 == a % 10 && a / 1000 % 10 == a / 10 % 10)
    Console.WriteLine("Число является палиндромом ");
else
    Console.WriteLine("Число не является палиндромом ");
    