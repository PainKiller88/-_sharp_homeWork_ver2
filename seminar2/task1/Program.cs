// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int Prompt(string message)
{
    Console.Write (message) ;
string vatue  = Console.ReadLine() ;
int result = Convert.ToInt32(vatue) ;
return result;

}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool VatidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третья цифра нет");
        return false;
    }
    return true;

}
int number = Prompt("Введите число  > ");
    if (VatidateNumber(number) )
    {
        Console .WriteLine (GetThirdRank (number) );
    }



