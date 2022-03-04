/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
*/

static double GetDistancePoints(double x1, double y1, double z1, 
                              double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;
    double result = Math.Sqrt(Math.Pow(xDistance, 2) + 
                    Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
    return result;
}

double xA, yA, zA, xB, yB, zB;
Console.WriteLine("Введите координиты первой точки A: ");
xA = Convert.ToInt32(Console.ReadLine());
yA = Convert.ToInt32(Console.ReadLine());
zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки B: ");
xB = Convert.ToInt32(Console.ReadLine());
yB = Convert.ToInt32(Console.ReadLine());
zB = Convert.ToInt32(Console.ReadLine());

Console.Write("Растояние между точками A и B: ");
Console.WriteLine(Math.Round(GetDistancePoints(
                             xA, yA, zA, xB, yB, zB), 2));
