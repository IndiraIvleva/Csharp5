/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

using static System.Console;
Clear();

Write("Введите размер массива: ");
int s = Convert.ToInt32(ReadLine());
Write("Введите min диапазон массива: ");
int a = Convert.ToInt32(ReadLine());
Write("Введите max диапазон массива: ");
int b = Convert.ToInt32(ReadLine());

int[] massive = GetArray(s, a, b);
WriteLine($"[{String.Join(", ", massive)}]");

WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {GetSum(massive)}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}


int GetSum(int[] Mass)
{
    int sum = 0;
        for (int i = 0; i < Mass.Length; i+=2)
        {
            sum += Mass[i];
        }
    return sum;
}
