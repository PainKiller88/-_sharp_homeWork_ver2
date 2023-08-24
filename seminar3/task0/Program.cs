// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Qudrant(int axisX, int axisY)
{
    int num = 0;
    // if (axisX > 0 && axisY > 0)
    //     num = 1;
    // else if (axisX < 0 && axisY > 0)
    //     num = 2;
    // else if (axisX < 0 && axisY < 0)
    //     num = 3;
    // else if (axisX > 0 && axisY < 0)
    //     num = 4;
    // return num;
    if (axisX > 0)
    {
        if (axisX > 0) num = 1;
        else num = 4;
    }
    else if (axisX < 0)
    {
        if (axisY > 0) num = 2;
        else num = 3;
    }
    return num;
}

int x = InputNum("Введите координату X: ");

int y = InputNum("Введите координату Y: ");

int res = Qudrant(x, y);
if (res == 0)
    Console.WriteLine("Точка лежит на границе четвертей");
else
    Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в четверти {res}");
