using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
internal class Program
{

    private static void Main(string[] args)
    {
        // Рандом
        Random rand = new Random();
        // массив с данными
        int[] array = new int[10000];
        // список данных
        List<int> list = new List<int>();
        // хэш таблица
        Hashtable hash = new Hashtable();

        // заполнение рандомными числами
        for (int i = 0; i < array.Length; i++)
        {
            int random = rand.Next(1, 1000);
            hash.Add(i, random);
            array[i] = random;
            list.Add(random);

        }


        Stopwatch stopWatch = new Stopwatch();

        Console.WriteLine($"Введите число которое будем искать");
        int target = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Прямой способ");
        Console.WriteLine();

        Console.WriteLine($"Ищем число {target} в массиве");

        stopWatch.Start();

        // индекс для пробежки в цикле
        int index = 0;

        // проверка за выход массива за границу
        while (index < array.Length && array[index] != target)
        {
            index++;
            if (index < array.Length)
            {
                Console.WriteLine($"Число {target} нашлось");
                break;
            }
            else
            {
                Console.WriteLine($"Число {target} не нашлось");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");


        Console.WriteLine();
        Console.WriteLine("--------------------");
        Console.WriteLine();


        Console.WriteLine($"Ищем число {target} в списке");
        stopWatch.Reset();
        stopWatch.Start();

        index = 0;
        while (index < list.Count && list[index] != target)
        {
            index++;
            if (index < list.Count)
            {
                Console.WriteLine($"Число {target} нашлось");
                break;
            }
            else
            {
                Console.WriteLine($"Число {target} не нашлось");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

        Console.WriteLine();
        Console.WriteLine("--------------------");
        Console.WriteLine();


        Console.WriteLine($"Ищем число {target} в хэш таблице");
        stopWatch.Reset();
        stopWatch.Start();

        index = 0;
        while (index < hash.Count && Convert.ToInt32(hash[index]) != target)
        {
            index++;
            if (index < hash.Count)
            {
                Console.WriteLine($"Число {target} нашлось");
                break;
            }
            else
            {
                Console.WriteLine($"Число {target} не нашлось");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

        Console.WriteLine();
        Console.WriteLine("--------------------");

        Console.WriteLine();
        Console.WriteLine("Бинарный поиск");
        Console.WriteLine();


        Console.WriteLine($"Ищем число {target} в массиве");
        stopWatch.Reset();
        stopWatch.Start();

        int middle, left = 0, right = array.Length - 1;
        middle = (left + right) / 2;
        if (target > array.Length)
            left = middle + 1;
        else
            right = middle - 1;
        while ((array[middle] != target) && (left <= right))
        {
            if (array[middle] == target)
            {
                Console.WriteLine($"Число {target} нашлось");
                break;
            }
            else
            {
                Console.WriteLine($"Число {target} не нашлось");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");


        Console.WriteLine();
        Console.WriteLine("--------------------");
        Console.WriteLine();



        Console.WriteLine($"Ищем число {target} в списке");
        stopWatch.Reset();
        stopWatch.Start();

        left = 0;
        right = list.Count - 1;
        middle = (left + right) / 2;
        if (target > list.Count)
            left = middle + 1;
        else
            right = middle - 1;
        while ((list[middle] != target) && (left <= right))
        {
            if (list[middle] == target)
            {
                Console.WriteLine($"Число {target} нашлось");
                break;
            }
            else
            {
                Console.WriteLine($"Число {target} не нашлось");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

        Console.WriteLine();
        Console.WriteLine("--------------------");
        Console.WriteLine();


        Console.WriteLine($"Ищем число {target} в массиве");
        stopWatch.Reset();
        stopWatch.Start();

        left = 0;
        right = hash.Count - 1;
        middle = (left + right) / 2;
        if (target > hash.Count)
            left = middle + 1;
        else
            right = middle - 1;
        while ((Convert.ToInt32(hash[middle]) != target) && (left <= right))
        {
            if (Convert.ToInt32(hash[middle]) == target)
            {
                Console.WriteLine($"Число {target} нашлось");
                break;
            }
            else
            {
                Console.WriteLine($"Число {target} не нашлось");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

    }
}
