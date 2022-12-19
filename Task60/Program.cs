// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк массива (X): ");
int givenCol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (Y): ");
int givenRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество страниц массива (Z): ");
int givenPage = Convert.ToInt32(Console.ReadLine());

int[,,] arr = FillUniqNums(givenCol, givenRow, givenPage);
PrintMatrix(arr);

// Заполнение массива неповторяющимися двузначными числами
int[,,] FillUniqNums(int row, int col, int page)
{
    int[,,] matrix = new int[row, col, page];
    for (int k = 0; k < matrix.GetLength(2); k++)   // заполним массив 0 для будущего перебора элементов
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j, k] = 0;
            }
        }
    }
    int rnd = new Random().Next(10, 100);
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                while (NotUnique(matrix, rnd))  // ищем неповторяющееся в массиве число
                    rnd = new Random().Next(10, 100);
                matrix[i, j, k] = rnd;          // и присваиваем его новому элементу
            }
        }
    }
    return matrix;
}

// Проверка присутствия значения в массиве
bool NotUnique(int[,,] matrix, int num)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j, k] == num)
                    return true;
            }
        }
    }
    return false;
}

// Вывод массива
void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine();
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        Console.WriteLine($"Page {k}:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
