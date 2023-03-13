using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить одномерный массив с клавиатуры шестью целыми числами. Вывести одномерный массив в обратном порядке.
            //int [] array=new int [6];
            //int i;
            //for (i = 0; i <= 6; i++)

            //{
            //    Console.WriteLine($"array[{i}]=");
            //    array [i] = int.Parse(Console.ReadLine());
            //}
            //Console.Read();

            //Задача 2. В массиве хранятся сведения о количестве осадков, выпавших за каждый день января (использовать заполнение случайным образом целыми числами в диапазоне от 5 до 60 мм). Определить общее количество осадков за январь.
           
            int[] array = new int[31];
            Random random = new Random();
            for (int i = 0; i <6; i++)
            {
                array[i] = random.Next(5, 60);
                Console.WriteLine($"array[{i}={array[i]}");
            }
            int summ = 0;
            for (int i = 0; i <6; i++)
            {
                summ += array[i];
            }
            Console.WriteLine($"Общее кол-во осадков={summ}");
            Console.Read();
        }
    }
}
