// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] GetMatrixFromUser(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    Console.WriteLine($"Введите элементы матрицы (размер {rows}x{columns}) по одному. " + "Для каждого элемента введите значение и нажмите Enter:");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"[{i + 1}, {j + 1}]: ");
            matrix[i, j] = int.Parse(Console.ReadLine()!);
        }
    }

    return matrix;
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
        throw new Exception("Matrix dimensions do not match.");

    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }

            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}


Console.WriteLine("Введите значения для матрицы 1 (размер 2x2):");
int[,] matrix1 = GetMatrixFromUser(2, 2);

Console.WriteLine("Введите значения для матрицы 2 (размер 2x2):");
int[,] matrix2 = GetMatrixFromUser(2, 2);

int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

Console.WriteLine("Результат умножения матриц:");
PrintMatrix(resultMatrix);
