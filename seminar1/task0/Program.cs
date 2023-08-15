//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Это программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. ");
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine($"Первое число {number1} больше второго числа {number2}");
}

else if (number1 < number2)
{
    Console.WriteLine($"Второе число {number2} больше первого числа {number1}");
}