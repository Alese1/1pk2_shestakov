using System;
using System.Xml.Schema;

namespace task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, min;
            Random rnd = new Random();
            Console.WriteLine("видите длину матрицы");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
            }
            int[,] ints = new int[n, n];
            int[] number = new int[3];
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rnd.Next(10, 100);

                }
            }
            min = ints[0, 0];//нашли мин
            //умножение массива
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] *= min;
                }
                {
                    for (int h = 0; h < n; h++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            for (int k = 0; k < number.Length; k++)
                            {
                                if (ints[i, j] > number[k])
                                {
                                    for (int l = number.Length - 1; l > k; l--)
                                    {
                                        number[l] = number[l - 1];
                                    }
                                    number[k] = ints[i, j];
                                    break;

                                }
                            }
                        }
                    }
                    Console.WriteLine("Вывод массива с выделеными цветами");
                    {
                        for (int j = 0; j < ints.GetLength(1); j++)
                        {
                            bool b = false;
                            for (int k = 0; k < number.Length; k++)
                            {
                                if (ints[i, j] == number[k])
                                {
                                    b = true;
                                    break;
                                }
                            }
                            if (b)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                            }
                            Console.Write(ints[i, j]);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}