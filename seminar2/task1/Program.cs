// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int DelSecondDig(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;

    int result = firstDigit * 10 + secondDigit;
    return result;
}

int randomNumber = new Random().Next(100, 1000);

System.Console.WriteLine($"(randomNumber) - > {DelSecondDig(randomNumber)}");