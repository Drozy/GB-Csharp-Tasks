// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);

int[] expandArray = ExpandMatrix(arr);
CollectionSort(expandArray);
// Console.WriteLine($"[{String.Join(", ", expandArray)}]");
RepeatRate(expandArray);


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

// Разворот матрицы в одномерный массив
int[] ExpandMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[n];
    n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;
        }
    }
    return array;
}

// Сортировка элементов по возрастанию
void CollectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        if (i != minPosition)
        {
            int tmp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = tmp;
        }
    }
}

// Вывод количества повторений значения элемента массива
void RepeatRate(int[] array)
{
    int save = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == save)
            count++;
        else
        {
            Console.WriteLine($"{save} - {count} шт");
            save = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
            Console.WriteLine($"{save} - {count} шт");
    }
}