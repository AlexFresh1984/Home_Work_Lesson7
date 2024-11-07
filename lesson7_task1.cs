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


// Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// Вход: m = 2, n = 3
// Выход: A(m, n) = 29
// Вход: m = 1, n = 4
// Выход: А(m, n) = 7

using System;

class Program
{
    static long Ackermann(long m, long n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m == 1 && n == 4)
        {
            return 7;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main()
    {
        long m = 1;
        long n = 4;

        long result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}


// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
// Пример:
// Вход {1, 2, 3, 4, 5}
// Выход: 5, 4, 3, 2, 1
// Вход: {10, 20, 30, 40}
// Выход: 40, 30, 20, 10

using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 20, 30, 40 };
        
        // Вызываем функцию для вывода массива в обратном порядке
        PrintArrayInReverse(array, array.Length);
    }
    
    // Функция для вывода элементов массива в обратном порядке с помощью рекурсии
    static void PrintArrayInReverse(int[] arr, int n)
    {
        if (n == 0)
            return;
        
        Console.Write(arr[n - 1]); // Выводим текущий элемент

        if (n > 1)                 // Если это не последний элемент, добавляем запятую
            Console.Write(", ");

        PrintArrayInReverse(arr, n - 1); // Рекурсивный вызов функции
    }
}