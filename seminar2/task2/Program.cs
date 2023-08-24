// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

bool Multiplicity(int firstNum, int secondNum)

{
    // if (firstNum % secondNum == 0)
    //     return true;
    // else
    //     return false;
    return firstNum % secondNum == 0;
}

int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");

bool check = Multiplicity(firstNum, secondNum);
Console.WriteLine(check);