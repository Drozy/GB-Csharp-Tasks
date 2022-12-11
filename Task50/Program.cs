// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);
FindElement(arr);

// Заполнение массива случайными числами
int[,] FillMatrixRnd(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Вывод элемента массива по заданным пользователем номеру строки и столбца (не индексам)
void FindElement(int[,] matrix)
{
    Console.Write("Введите номер строки искомого элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца искомого элемента: ");
    int col = Convert.ToInt32(Console.ReadLine());
    if (row > matrix.GetLength(0)
        || row - 1 < 0
        || col > matrix.GetLength(1)
        || col - 1 < 0)
    { Console.WriteLine("Такой позиции нет в массиве."); }
    else
    { Console.WriteLine($"\nИскомый элемент: {matrix[row - 1, col - 1]}"); }
}