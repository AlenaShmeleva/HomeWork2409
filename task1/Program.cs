// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Ввведите пятизначное число: ");
string a = Convert.ToString(Console.ReadLine());
if (a[0] == a[4] && a[1] == a[3])
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");