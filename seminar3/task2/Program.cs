// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int InputMax(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string GetTable(int num)
{
    int count = 1;
    string result = "";
    while (count <= num)
    {
        result += $"(Math.Pow(count, 2))";
        if (count < num) result += ",";
        else result += ".";

    }
    return result;
}
int number = InputMax("Введите число: ");
Console.WriteLine(GetTable(number));