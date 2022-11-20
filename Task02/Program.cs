// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое сило большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

if (numOne > numTwo)
{
    Console.WriteLine($"Первое число {numOne} больше второго {numTwo}");
}
else if (numOne == numTwo) 
    {
        Console.WriteLine("Числа равны");
    }
    else Console.WriteLine($"Второе число {numTwo} больше первого {numOne}");
