// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N
// Само N не включаю

Console.Write("Введите число: "); 
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)  
{
    for (int i=2; i < N; i+=2)
    {
        Console.Write($"{i} ");
    }
}
else    // а вдруг ввели отрицательное число
{
    for (int i=0; i > N; i-=2)
    {
        Console.Write($"{i} ");
    }
}