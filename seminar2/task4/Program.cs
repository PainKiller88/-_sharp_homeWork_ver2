// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void IsSquare(int num1, int num2)
{
    if (num1 * num1 == num2)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");

IsSquare(firstNum, secondNum);