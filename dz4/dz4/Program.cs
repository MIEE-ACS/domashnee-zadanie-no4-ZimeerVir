using System;
using System.Collections.Generic;

namespace dz4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заполняем массив
            Console.WriteLine("Укажите длинну массива");
            int len = int.Parse(Console.ReadLine());
            Random rand = new Random();
            List<int> array = new List<int>();
            int first_null_index = 0;
            int second_null_index = 0;
            string array_result = "";

            for (int i = 0; i < len; i++)
            {
                array.Add(rand.Next(4));
                if (array[i] == 0 && first_null_index == 0)
                {
                    first_null_index = i;
                }
                if(array[i] == 0 && first_null_index !=0 ){
                    second_null_index = i;
                }
                array_result += array[i].ToString() + " ";
            }
            double result = 1;

            for (int i = 1; i < len; i += 2) {
                result = result * array[i];
            }


             Console.WriteLine(array_result);
           
            Console.WriteLine("==============================");
            Console.WriteLine($"Произведение четных номеров равно: {result}");

            int sum_result = 0;
            for (int i = first_null_index; i < second_null_index; i++) {
                sum_result += array[i];
            }
            Console.WriteLine($"Сумма элементов между нулями равна: {sum_result}");
            Console.WriteLine("==============================");

            array[0] = -array[0]; //Добавим отрицательных числе для проверки


            List<int> new_array = new List<int>();
            string new_array_result = "";
            for (int i = 0; i < len; i++) {
                if (array[i] > 0 || array[i] == 0)
                {
                    new_array.Add(array[i]);
                }
            }
            for (int i = 0; i < len; i++) {
                if (array[i] < 0)
                {
                    new_array.Add(array[i]);
                }
                new_array_result += new_array[i].ToString() + " ";
            }
            Console.WriteLine($"Преобразованный массив \n {new_array_result}");

        }
    }
}
