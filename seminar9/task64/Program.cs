//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNumbers(int number)
{
    // базовый случай - когда достигнуто число 1
    if (number == 1)
    {
        return;
    }

    // рекурсивный случай - выводим текущее число и продолжаем рекурсивно вызывать функцию для следующего числа
    Console.Write(", " + (number - 1).ToString());

    PrintNumbers(number - 1);
}


Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write(n);

PrintNumbers(n);

Console.ReadKey();

