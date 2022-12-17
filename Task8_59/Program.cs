// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);

Console.WriteLine($"Позиция наименьшего элемента [{String.Join(", ", FindMinPosition(arr))}]");
int[,] newArr = RemoveCross(arr, FindMinPosition(arr));
PrintMatrix(newArr);

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

// Позиция минимального элемента
int[] FindMinPosition(int[,] matrix)
{
    int[] pos = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                pos[0] = i;
                pos[1] = j;
            }
        }
    }
    return pos;
}

// Удаление строки и столбца по индексам элемента
int[,] RemoveCross(int[,] matrix, int[] pos)
{
    int row = matrix.GetLength(0) - 1;
    int col = matrix.GetLength(1) - 1;
    int[,] result = new int[row, col];
    int iRes = 0, jRes = 0;     // позиции элементов результирующего массива
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == pos[0])
            continue;   // пропускаем указанную строку
        else
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == pos[1])
                    continue;   // пропускаем указанный столбец
                else
                {
                    result[iRes, jRes] = matrix[i, j];
                    jRes++;
                }
            }
            iRes++;
            jRes = 0;   // сбрасываем индекс столбца результата
        }
    }
    return result;
}
