using System;
using System.Collections.Generic;
using System.Linq;


namespace DZ4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // заполняем массив корректными данными для проверки
            const int N = 4;
            int[,] arr = new int[N, N] { { 1, 1, 0, 9 }, { 2, 2, 2, 0 }, { 3, 3, 3, 3 }, { 7, 3, 1, 0 } };
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"    {arr[i, j]}    ");
                }
                Console.WriteLine();
            }

            // Задание 1
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (arr[j, i] == 0)
                    {
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Число столбцов с нулевыми элементами: {counter}");


            // Задание 2
            var couters_list = new List<int>();
            int counter_1;
            for (int i = 0; i < N; i++)
            {
                counter_1 = 0;
                for (int j = 0; j < N-1; j++)
                {
                    int first_element = arr[i, j];
                    if (arr[i, j] == arr[i, j+1])
                    {
                        counter_1++;
                    }
                }
                couters_list.Add(counter_1);
            }
            int max_serias = couters_list.Max();
            if (max_serias == 0)
            {
                Console.WriteLine($"Нет серий элементов в строке");
            }
            else {
                Console.WriteLine($"Серия одинаковых элеемнтов максимальна в строке: {couters_list.IndexOf(max_serias)}");
            }
            
        }
    }
}
