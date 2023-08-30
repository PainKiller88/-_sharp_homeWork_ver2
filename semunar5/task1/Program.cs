// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
// Метод для запроса у пользователя длины массива
int GetUserInput(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Метод для запроса у пользователя длины массива
int[] FillArray(int length) 
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-1000, 1000);
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
//Метод для суммирования элементов массива.
int SumOfElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        if (array[i] >= 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
 
int length = GetUserInput("Введите длину массива: ");
int[] array = FillArray(length);
Console.WriteLine("Массив: " + ArrayToString(array));
int sum = SumOfElements(array);
Console.WriteLine("Сумма элементов массива на нечетных позициях: " + sum);