// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

// Метод для запроса у пользователя длины массива
int GetUserInput(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

// Метод для создания массива вещественных чисел
double[] CreateArray(int length)
{
    double[] array = new double[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        // Генерация случайного числа от 0 до 100 с округлением до 2 знаков после запятой
        array[i] = Math.Round(random.NextDouble() * 100, 2);
    }

    return array;
}

// Метод для преобразования массива в строку.
string ArrayToString(double[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length - 1; i++)
    {
        result += array[i] + "; ";
    }
    result += array[array.Length - 1] + "]";
    return result;
}

// Метод для нахождения максимального элемента массива.
double FindMax(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}

// Метод для нахождения минимального значения массива
double FindMin(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}


int length = GetUserInput("Введите длину массива: ");
double[] array = CreateArray(length);
double max = FindMax(array);
double min = FindMin(array);
Console.WriteLine($"Массив:{ArrayToString(array)} => {max} - {min} = {max-min} ");

