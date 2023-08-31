// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
// Метод запроса ввода данных у пользователя
int GetUserInput(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
//Метод для запроса у пользователя длины массива
int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }

    return array;
}
// Метод для преобразования массива в строку.
string ArrayToString(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length - 1; i++)
    {
        result += array[i] + ", ";
    }
    result += array[array.Length - 1] + "]";
    return result;
}
// Метод расчета количества четных чисел
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int length = GetUserInput("Введите длину массива: ");
int[] array = FillArray(length);
Console.WriteLine("Массив: " + ArrayToString(array));
int count = CountEvenNumbers(array);
Console.WriteLine("Количество четных чисел: " + count);


