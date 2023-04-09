/* 
ДОМАШНЕЕ ЗАДАНИЕ 09.04.2023 

Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Console.Write("Введите M чисел массива: ");
int M = int.Parse(Console.ReadLine());
int[] Array = new int[M];

void MNumbers(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        Array[i] = int.Parse(Console.ReadLine());
    }
}

int AverageZero(int[] Array)
{
    int i = 0;
    int sum = 0;
    while (i < Array.Length)
    {
        if (Array[i] > 0)
            sum = sum + 1;
        i = i + 1;
    }
    return sum;
}

MNumbers(M);
Console.Write($"\n Больше нуля: { AverageZero(Array)} числа");

____________________________ 

 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

РЕШЕНИЕ 
*/

Console.WriteLine("Я программа, которая посчитает точки пересечения двух прямых.");
Console.WriteLine("Введите точку начала первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите точку конца первой прямой:  ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите точку начала второй прямой:  ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите точку конца второй прямой:  ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1-b2) / (k1-k2);
double y = k1 * x + b1;

Console.Write($"\n Прямые пересекаются в точке: ({ x} ; { y})");
