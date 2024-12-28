﻿using Tyuiu.MajdQadhi.Sprint4.Task0.V1.Lib;

namespace Tyuiu.MajdQadhi.Sprint4.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            Console.Title = "Спринт #4 | Выполнил: Кадхи М. Н. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Кадхи М. Н. | ИИПБ-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива. {6 ,4 ,3 ,2 ,1 ,0 ,9 ,8 ,7 ,5}                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*									      *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = {6,4,3,2,1,0,9,8,7,5};

            Console.WriteLine("Исходный массив :");

            for(int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine($"[{i}] = {numsArray[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма всех четных чисел равна = " + ds.GetSumEvenArrEl(numsArray));
            Console.ReadKey();
        }
    }
}
