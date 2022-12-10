// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

void Triange(int n1, int n2, int n3)
{
    if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2)
        Console.WriteLine($"Треугольник со сторонами {n1}, {n2}, {n3} существует.");
    else Console.WriteLine($"Треугольника со сторонами {n1}, {n2}, {n3} не существует.");
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

Triange(a, b, c);