// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Ввведите координаты первой точки по оси X ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координаты первой точки по оси Y ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координаты первой точки по оси Z ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координаты второй точки по оси X ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координаты второй точки по оси Y ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координаты второй точки по оси Z ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1)));