// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Из Wiki:
// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1

double ack(double m, double n)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = ack(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}

// int ackM = 1;
// int ackN = 1;
// Console.WriteLine($"ack({ackM}, {ackN}) = {ack(ackM, ackN)}");

for (int i = 0; i < 4; i++) // переполнение при расчете ack(3,1))
{
    Console.WriteLine();
    for (int j = 0; j < 2; j++) // при j = 3 переполнение ~19k повторов :)
        Console.Write($"ack({i}, {j}) = {ack(i, j)}\t");
}