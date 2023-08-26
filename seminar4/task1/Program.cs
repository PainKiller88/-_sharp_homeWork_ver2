// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

/*Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


int count = 0;
while (number != 0)
{
    number /=10;
    count++;
}
Console.WriteLine(count);*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите число: ");
int i;
for (i = 0; num !=0; i++)
{
    num /=10;
}
System.Console.WriteLine(i);