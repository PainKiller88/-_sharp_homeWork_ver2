// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8
Console.Clear();
int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit)
    {
        return firstDigit;
    }
    else
    {
        return secondDigit;
    }
}
int number =new Random().Next(10, 100); // Случайное число из отрезка [10, 99)
int res = MaxDigit(number);
Console.WriteLine($"В числе {number} максимальная цифра {res}");