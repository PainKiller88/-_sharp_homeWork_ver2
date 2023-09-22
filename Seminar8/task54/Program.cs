//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


static int[,] GetUserInput()
{
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов: ");
    int cols = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение: ");
    int minVal = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение: ");
    int maxVal = int.Parse(Console.ReadLine()!);

    int[,] array = new int[rows, cols];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(minVal, maxVal + 1);
        }
    }

    return array;
}

void SortRowsDescending(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            for (int k = j + 1; k < cols; k++)
            {
                if (array[i, k] > array[i, j])
                {
                    Swap(ref array[i, j], ref array[i, k]);
                }
            }
        }
    }
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] array = GetUserInput();

Console.WriteLine("Случайный массив:");
PrintArray(array);

SortRowsDescending(array);

Console.WriteLine("Упорядоченный массив:");
PrintArray(array);

Console.ReadLine();
