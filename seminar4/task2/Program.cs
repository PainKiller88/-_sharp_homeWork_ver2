// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int InputNum(string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine()!);
}



int Factorial(int num)
{

int mul = 1;
for(int i = 2; i <= num; i++)
mul *= i;
return mul;
}

int num = InputNum(" введите число : ");

int fact = Factorial(num);
Console.WriteLine(fact);