namespace Task_03_06
{
    internal class Program
    {
        /* Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5.*/
        static void Main(string[] args)
        {
            double a1 = -4, a2 = 4, shag = 0.5;
            Console.WriteLine("x                y");
            Console.WriteLine("____________________");
            for (double i = a1; a1 <= a2; a1 += shag)
            {
                Console.WriteLine(a1 + "                " + Math.Round(Math.Abs(a1), 1));

            }
        }
    }
}