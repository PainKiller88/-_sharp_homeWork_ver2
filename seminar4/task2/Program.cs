// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

**_Задание полностью списано_**

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int [] FillArray(int Length, int minValue, int maxValue)

{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;

}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} , ");
        
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

 

int length = InputNum("Введите длину массива: ");
int min = InputNum("Введите минимальное значение массива: ");
int max = InputNum("Введите максимальное значение массива: ");
int [] array = FillArray(length, min, max);

PrintArray(array);


