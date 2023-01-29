Console.Clear();
Console.WriteLine("Введите два числа: ");
Console.Write("Введите первое число:  ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число:  ");
int b = int.Parse(Console.ReadLine()!);
if (a > b) 
    {
        Console.WriteLine($"Первое число {a} больше второго {b}.");
    }
else if (a < b)
    {   
        Console.WriteLine($"Второе число {b} больше первого {a}.");
    }
else
    Console.WriteLine("Числа равны.");
