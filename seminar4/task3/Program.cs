// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int EnterSum(string phrase)
{
    Console.WriteLine(phrase);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] array)
{
    for (int i = 0; i < args.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
}

void PrintArray(int[] array)
{
    foreach (int value in array)
{
    Console.WriteLine(value + " ");
}
}
int size = EnterSum("EnterSum number for array, phrase");
int[] arr = new int[size];

FillArray(arr);
PrintArray(arr);