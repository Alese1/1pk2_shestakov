namespace Task_04_07
{
    internal class Program
    {
        /*Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения которых равны.*/
        static void Main(string[] args)
        {
            int[] namber = new int[50];
            Random rnd = new Random();
            int pary = 0;
            for (int i = 0; i < namber.Length; i++)
            {
                namber[i] = rnd.Next(1, 11);
            }
            for (int i = 0; i < namber.Length; i++)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (namber[i] == namber[j])
                    {
                        pary++;
                    }
                }

            }
            Console.WriteLine($"Количество пар чисел - {pary}");
        }
    }
}
}
