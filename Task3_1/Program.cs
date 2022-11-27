// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Задайте координаты точки");
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if ((x == 0) || (y == 0)) 
Console.WriteLine("Координаты не должны быть равны 0");
else
{
    if (x > 0)
    {
         if (y > 0) Console.WriteLine("1 четверть");
         else Console.WriteLine("4 четверть");
    }
    else 
    {
        if (y > 0) Console.WriteLine("2 четверть");
        else Console.WriteLine("3 четверть");
    }
}
