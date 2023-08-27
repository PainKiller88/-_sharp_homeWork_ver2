// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int Exponentiation(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}

int num1 = InputNum("Введите первое число: ");
int num2 = InputNum("Введите второе число: ");
Console.WriteLine($"Результат: {Exponentiation(num1, num2)}");