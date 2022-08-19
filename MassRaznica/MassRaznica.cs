/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

using static System.Console;
Clear();

Write("Введите размер массива: ");
int s = Convert.ToInt32(ReadLine());
double[] array = GetArray(s);
WriteLine($"[{String.Join(", ", array)}]");

WriteLine($"Min элемент - {GetMin(array)}");
WriteLine($"Max элемент - {GetMax(array)}");
WriteLine($"Разница между Max и Min элементов массива = {GetMax(array) - GetMin(array)}");

double[] GetArray(int num)
{
    double[] result = new double[num];
    for (int i = 0; i < num; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

double GetMin(double[] Mass)
{
    double min = Mass[0];
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] < min)
        {
            min = Mass[i];
        }
    }
    return min;
}

double GetMax(double[] Mass)
{
    double max = Mass[0];
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] > max)
        {
            max = Mass[i];
        }
    }
    return max;
}