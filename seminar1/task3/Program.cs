// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Данная программа принимает на вход число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Четные числа от 1 до {number}:");

        for (int i = 2; i <= number; i += 2)
        {
            Console.Write(i + " ");
        }
