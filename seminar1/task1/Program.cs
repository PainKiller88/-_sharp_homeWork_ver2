﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("\nВведите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("\nВведите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

int max = 0;

if (number1 > number2){
    max = number1;
}
else {
    max = number2;
}
if (number3 > max){
    max = number3;
}
Console.WriteLine($"Максимальное число {max}.");
