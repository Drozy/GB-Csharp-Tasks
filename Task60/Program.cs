// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;

Console.Write("Введите количество строк массива: ");
int givenCol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int givenRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество страниц массива: ");
int givenPage = Convert.ToInt32(Console.ReadLine());
int[,,] arr = CreateMatrix(givenCol, givenRow, givenPage);

PrintMatrix(arr);


// Заполнение массива
int[,,] CreateMatrix(int row, int col, int page)
{
    int[,,] matrix = new int[row, col, page];
     

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = GetUniqueNum(matrix, i, j, k);
            }
        }
    }
    return matrix;
}

// Генератор уникального элемента в массиве, сравнение с предыдущими (уже заданными)
// не работает :*(
int GetUniqueNum(int[,,] matrix, int a, int b, int c)
{
    int num;
mark: num = new Random().Next(10, 30);
    for (int k = 0; k < c; k++)
    {
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (num == matrix[i, j, k]) goto mark;
            }
        }
    }
    return num;
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
