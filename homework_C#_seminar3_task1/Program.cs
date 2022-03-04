/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
*/

string testNumber(int arg)
{
    bool flag = true;
    int count = 1;
    string numString = Convert.ToString(arg);
    int numLen = numString.Length;
    int numHalf = numLen / 2;
    while (count < numHalf + 1)
    {
        if (numString[count - 1] != numString[numLen - count])
        {
            flag = false;
        }
        count++;
    }
    if (flag == true) return "Да";
    else return "Нет";
}

Console.WriteLine("Введите число, чтобы проверить является ли оно " +
                  "палиндромом: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(testNumber(num));
