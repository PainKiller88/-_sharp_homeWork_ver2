// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели (от 1 до 7):");
        int day = int.Parse(Console.ReadLine());

        bool isWeekend = IsWeekend(day);

        if (isWeekend)
        {
            Console.WriteLine("Этот день является выходным");
        }
        else
        {
            Console.WriteLine("Этот день не является выходным");
        }
    

    bool IsWeekend(int day)
    {
        return day == 6 || day == 7;
    }