Console.Clear();
Console.Write("Введите любое целое число: ");
long a = long.Parse(Console.ReadLine())!;
if ( a % 2 == 0)
    Console.WriteLine($"Число {a} четное.");
else
    Console.WriteLine($"Число {a} нечетное.");

