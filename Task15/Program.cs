// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
if ((dayNum < 1) || (dayNum > 7))
    Console.WriteLine("ошибка ввода");
else if (dayNum < 6)
    Console.WriteLine("Рабочий день");
else Console.WriteLine("Выходной");
