/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

using static System.Console;
Clear();

WriteLine("Введите размер массива:");
int s = Convert.ToInt32(ReadLine());
int[] array = GetArray(s);
WriteLine($"[{String.Join(", ", array)}]");
WriteLine($"Количество четных чисел в массиве равно {GetCount(array)}");


int[] GetArray(int num)
{
    int[] result = new int[num];

    for (int i = 0; i < num; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int GetCount(int[] Mass)
{
    int count = 0;
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] % 2 == 0)
            {
                count+=1;
            }
    }
    return count;
}