// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNaturalNumbers(int M, int N)
{
    if (M == N)
    {  // Если M = N, то возвращаем M (или N)
        return M;
    }
    else if (M > N)
    {
        return 0;  // Базовый случай: сумма чисел от M до N, где M > N, равна 0
    }
    else
    {
        return M + SumNaturalNumbers(M + 1, N);  // Рекурсивно вычисляем сумму для промежутка с M + 1 до N и добавляем к M
    }
}


Console.WriteLine("Введите число M:");  // Запрашиваем M у пользователя
int M = Int32.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N:");  // Запрашиваем N у пользователя
int N = Int32.Parse(Console.ReadLine()!);

int sum = SumNaturalNumbers(M, N);  // Вызываем функцию для вычисления суммы
Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
