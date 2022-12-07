// Двумерные массивы или матрицы

// Вывод элементов через цикл в цикле
void PrintArray(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)   // перебираем строки, GetLenght(0) выдает количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // перебираем столбцы, GetLenght(1) выдает количество столбцов
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Заполнение массива случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int [,] matrix = new int[3,4];  // 3 строки и 4 столбца
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
