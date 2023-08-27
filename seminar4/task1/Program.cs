//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
static int GetDigitSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
int num = InputNum("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {num} = {GetDigitSum(num)}");