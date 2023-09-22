// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int[,,] GenerateArray()
{
    int[,,] array = new int[2, 2, 2];
    Random rand = new Random();

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                int uniqueNumber;
                do
                {
                    uniqueNumber = rand.Next(10, 100);
                } while (ArrayContains(array, uniqueNumber));

                array[i, j, k] = uniqueNumber;
            }
        }
    }

    return array;
}

bool ArrayContains(int[,,] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
        {
            return true;
        }
    }
    return false;
}

void DisplayArrayWithIndices(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


 int[,,] array = GenerateArray();
DisplayArrayWithIndices(array);
    