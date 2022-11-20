// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня: ");
int numDay = Convert.ToInt32(Console.ReadLine());
switch (numDay)
{
    case 1:
        Console.WriteLine($"{numDay} -> понедельник");
        break;
    case 2:
        Console.WriteLine($"{numDay} -> вторник");
        break;
    case 3:
        Console.WriteLine($"{numDay} -> среда");
        break;
    case 4:
        Console.WriteLine($"{numDay} -> четверг");
        break;
    case 5:
        Console.WriteLine($"{numDay} -> пятница");
        break;
    case 6:
        Console.WriteLine($"{numDay} -> суббота");
        break;
    case 7:
        Console.WriteLine($"{numDay} -> воскресенье");
        break;
    default:
        Console.WriteLine("Неправильный номер");
        break;
}