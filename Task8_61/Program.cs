﻿// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
int[,] triangle = new int[row, row];
const int cellWidth = 3;    // ширина вывода элемента, корректный вывод пятизначных чисел

// Заполнение треугольника Паскаля
void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j < row; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j]; // сумма элементов над искомым (треугольное число)
        }
    }
}

// Вывод треугольника Паскаля в виде равнобедренного треугольника
void PrintTriangle()
{
    Console.Clear();
    int col = cellWidth * row;  // величина отступа слева
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0)    // выводим ненулевые элементы
                Console.Write($"{triangle[i, j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

FillTriangle();
PrintTriangle();
