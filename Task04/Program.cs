// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

int n = 3; // количество чисел
int[] nums = new int[n]; // массив для чисел
int max;    // переменная для максимального числа

for (int i=0; i < n; i++)   // вводим наши числа
{
    Console.WriteLine($"Введите {i+1} число: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

max = nums[0];
for (int i=1; i < n; i++)   // ищем максимум
{
    if (max < nums[i])
        max = nums[i];
}

Console.WriteLine($"Максимальное число: {max}");
