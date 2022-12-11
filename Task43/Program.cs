// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение без использования функций и массивов
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// if (k1 == k2)
// {
//     if (b1 == b2) Console.WriteLine("Прямые совпадают");
//     else Console.WriteLine("Прямые не пересекаются");
// }
// else 
// {
// // double x = (b2 - b1) / (k1 - k2);
// // double y = k2 * x + b2;
// // Console.WriteLine($"Координаты точки пересечения ({x}; {y})");
// }

// С функциями и массивами
Console.WriteLine("Введите через пробел параметры первой линии (k1 и b1):");
double[] line1 = GetArrayFromString(Console.ReadLine());
Console.WriteLine("Введите через пробел параметры второй линии (k2 и b2):");
double[] line2 = GetArrayFromString(Console.ReadLine());
if (line1[0] == line2[0])
{
    if (line1[1] == line2[1]) Console.WriteLine("Прямые совпадают");
    else Console.WriteLine("Прямые не пересекаются");
}
else Console.WriteLine($"Координаты точки пересечения ({String.Join(", ", JunctionCoordinates(line1, line2))})");

double[] GetArrayFromString(string input)  // ввод массива пользователем
{
    string[] arrayChar = input.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
    double[] numbers = new double[arrayChar.Length];
    for (int i = 0; i < arrayChar.Length; i++) { numbers[i] = double.Parse(arrayChar[i]); }
    return numbers;
}

double[] JunctionCoordinates(double[] line1, double[] line2)    // нахождение координат точки пересечения 2 линий
{
    double[] junction = new double[2];
    junction[0] = (line2[1] - line1[1]) / (line1[0] - line2[0]);       // 0 индекс = k, 1 индекс = b
    junction[1] = line2[0] * junction[0] + line2[1];
    return junction;
}
