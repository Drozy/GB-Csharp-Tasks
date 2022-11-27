// 21) 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
Console.WriteLine($"Расстояние между точками {d}");

