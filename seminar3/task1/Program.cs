// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int InputMax(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double PointDistance(int AX, int AY, int BX, int BY)
{
    double distance = 0;
    distance = Math.Sqrt(Math.Pow(AX - BX, 2) + Math.Pow(AY - BY, 2));
    return distance;
}

int AX = InputMax("Введите координату X точки A: ");

int AY = InputMax("Введите координату Y точки A: ");

int BX = InputMax("Введите координату X точки B: ");

int BY = InputMax("Введите координату Y точки B: ");
Console.WriteLine(PointDistance(AX, AY, BX, BY));