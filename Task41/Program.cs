// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArrayFromString(string input)  // ввод массива пользователем
{
    string[] arrayChar = input.Split(new char[] {' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
    int[] numbers = new int[arrayChar.Length];
    for (int i = 0; i < arrayChar.Length; i++) { numbers[i] = int.Parse(arrayChar[i]); }
    return numbers;
}

int CountPosNumbers(int[] a)    // количество чисел >0 в массиве
{
    int count = 0;
    foreach (int n in a)
    {
        if (n > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите числа через пробел:");
int[] array = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0:  {CountPosNumbers(array)}");
