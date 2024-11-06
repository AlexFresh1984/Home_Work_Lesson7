// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Используйте рекурсию и не используйте циклы.
// Примеры
// Вход: М = 1, N = 5
// Выход: 1, 2, 3, 4, 5
// Вход: М = 4, N = 8
// Выход: 4, 5, 6, 7, 8

using System;

class Program
{
    static void Main()
    {
        int m = 4;
        int n = 8;

        PrintNaturalNumbersRecursively(m, n);
        Console.WriteLine();
    }

    static void PrintNaturalNumbersRecursively(int currentNumber, int limit)
    {
        if (currentNumber > limit)
        {
            return;
        }

        Console.Write(currentNumber + " ");
        PrintNaturalNumbersRecursively(currentNumber + 1, limit);
    }
}

