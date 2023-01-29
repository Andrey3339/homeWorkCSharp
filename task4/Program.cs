Console.Clear();
Console.Write("Введите любое целое положительное число: ");
int a = int.Parse(Console.ReadLine());
int i = 1;
Console.Write("Все четные числа меньше введеного: ");
while(i <= a)
{
    if(i % 2 == 0)
        Console.Write(i + " ");
    i++;
}

