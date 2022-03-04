/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
*/

void DegreeNumber(double arg)
{
    double count = 1;
    while (count <= arg)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}

Console.WriteLine("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());
DegreeNumber(num);
