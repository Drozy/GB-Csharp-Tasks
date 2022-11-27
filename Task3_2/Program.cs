// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти:");
int n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1:
        Console.WriteLine("X > 0 и Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0 и Y > 0");
        break;
    case 3:
        Console.WriteLine("X < 0 и Y < 0");
        break;
    case 4:
        Console.WriteLine("X > 0 и Y < 0");
        break;
    default:
        Console.WriteLine("Ввели неверное значение");
        break;
}
