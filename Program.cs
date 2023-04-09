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

*/ 

