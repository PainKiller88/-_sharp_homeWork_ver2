// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumNum(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)

        sum += i;
    return sum;
}

int num = InputNum("Введите число: ");
int sum = SumNum(num);
Console.WriteLine(sum);