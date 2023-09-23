// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29





int m, n;

// Метод запроса данных у пользователя
Console.WriteLine("Введите два неотрицательных числа m и n:");
if (TryGetNonNegativeInt("m: ", out m) && TryGetNonNegativeInt("n: ", out n))
{
    if (m <= 3 && n <= 3)
    {
        // Вычисление функции Аккермана и вывод результата
        int result = Ackermann(m, n);
        Console.WriteLine($"m={m}, n={n}-> A(m,n) = {result}");
    }
    else
    {
        Console.WriteLine("Ошибка: Невозможно вычислить функцию Аккермана для m или n больше 3.");
    }
}
else
{
    Console.WriteLine("Ошибка ввода.");
}


// Метод проверки исключения ввода отрицательного или нецелого числа
bool TryGetNonNegativeInt(string prompt, out int value)
{
    Console.Write(prompt);
    if (int.TryParse(Console.ReadLine(), out value) && value >= 0)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Ошибка: Введите неотрицательное целое число.");
        value = 0;
        return false;
    }
}

// Метод вычисления функции Аккермана с использованием рекурсии
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}





