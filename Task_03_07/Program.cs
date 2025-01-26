namespace Task_03_07
{
    internal class Program
    {   /*Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
где 2 g = 9,8 м/с2 – ускорение свободного падения.*/

        static void Main(string[] args)
        {
            double g = 9.8; double t;
            Console.WriteLine("Введите ограничение времени");
            while (!double.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.Clear();
            Console.WriteLine("t            v");
            Console.WriteLine("_____________________");
            for (double i = 0.5; i <= t; i += 0.5)
            {
                Console.WriteLine($"{i}         {i * g}");
            }
        }
    }
}