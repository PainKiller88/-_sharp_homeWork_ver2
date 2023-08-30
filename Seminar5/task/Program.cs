// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// void FillArray(int[] ints)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < ints.Length; i++)
//         ints[i] = rnd.Next(-9, 10);
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.Write($"{arr[i]}  ");
//     Console.WriteLine();


// }
// void SumPosNegNums(int[] arr)
// {
//     int posSum = 0;
//     int negSum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//             posSum += arr[i];

//         else
//             negSum += arr[i];
//     }
//         Console.WriteLine($"Сумма положительных чисел равнна {posSum}");
//         Console.WriteLine($"Сумма отрицательных чисел равнна {negSum}");

// }

// int[] newArray = new int[12];
// FillArray(newArray);
// PrintArray(newArray);
// SumPosNegNums(newArray);

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// void ChengeSingn(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
// }

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {

//         Console.Write(array[i]);
//         if (i < array.Length - 1) Console.Write(", ");

//     }
//     Console.WriteLine();
// }
// int[] myArray = { -1, -6, 10, -17, 28, 8, 0, 7 };
// PrintArr(myArray);
// ChengeSingn(myArray);
// PrintArr(myArray);

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// void FindNum(int[] fNum, int num)
// {
//     int count = 0;
//     for (int i = 0; i < fNum.Length; i++)
//     {
//         if (fNum[i] == num)
//         {
//             count++;
//         }
//     }
//     if (count == 0)
//     {
//         Console.WriteLine("нет");
//     }
//     else
//     {
//         Console.WriteLine("да");
//     }

// }
// void PrintArray(int[] newArray)
// {
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         Console.Write(newArray[i]);
//         if (i < newArray.Length - 1) Console.Write(", ");

//     }
//     Console.WriteLine();
// }
// int[] oneArray = { -6, 7, 19, 345, 3 };
// PrintArray(oneArray);
// FindNum(oneArray, 3);

/*Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2]-> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5
*/
// void FillArray(int[] ints)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < ints.Length; i++)
//         ints[i] = rnd.Next(0, 201);
// }

// int AmountNumsInDiap(int[] array, int start, int end)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= start && array[i] <= end)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] arrayForNumbers = new int[123];

// FillArray(arrayForNumbers);
// int result = AmountNumsInDiap(arrayForNumbers, 10, 99);
// Console.WriteLine(result);

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
return new int[size];
}

void FillArray(int[] array, int minValue, int maxValue)
{
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rnd.Next(minValue, maxValue + 1);
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write($"{array[i]} ");
Console.WriteLine();
}

int[] MultPairs(int[] array)
{
int size = array.Length / 2 + array.Length % 2;
// int size = array.Length / 2;
// if (array.Length % 2 == 1) size++;
int[] newArr = new int[size];

for (int i = 0; i < array.Length / 2; i++)
newArr[i] = array[i] * array[array.Length - 1 - i];

if (array.Length % 2 == 1)
newArr[size - 1] = array[array.Length / 2];
return newArr;
}

int size = InputNum("Введите размер массива: ");
int[] ints = CreateArray(size);

int min = InputNum("Введите минимальное значение элемента массива: ");
int max = InputNum("Введите максимальное значение элемента массива: ");

FillArray(ints, min, max);
PrintArray(ints);

int[] result = MultPairs(ints);
PrintArray(result);/*  */