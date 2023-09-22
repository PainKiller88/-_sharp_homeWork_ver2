// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




int GetUserInput(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GenerateArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void DisplayArray(int[,] array)
{
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindMinSumRow(int[,] array)
{
    int minSumRowIndex = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}

int rows = GetUserInput("Введите количество строк: ");
int cols = GetUserInput("Введите количество столбцов: ");
int minValue = GetUserInput("Введите минимальное значение элементов массива: ");
int maxValue = GetUserInput("Введите максимальное значение элементов массива:");

int[,] array = GenerateArray(rows, cols, minValue, maxValue);
DisplayArray(array);

int minSumRowIndex = FindMinSumRow(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");



