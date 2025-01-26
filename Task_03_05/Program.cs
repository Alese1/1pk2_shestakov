namespace Task_03_05
{
    internal class Program
    {
        /*Написать программу,  которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
        Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
        время работы программы*/

        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон изменения температуры в градусах Цельсия и шаг изменения температуры.(числами)\n");
            double a1, a2, shag;
            Console.WriteLine("Введите начало диапазона");
            while (!double.TryParse(Console.ReadLine(), out a1))
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            }
            Console.WriteLine("Введите конец диапазона");
            while (!double.TryParse(Console.ReadLine(), out a2))
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            }
            Console.WriteLine("Введите шаг");
            while (!double.TryParse(Console.ReadLine(), out shag))
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            }
            Console.Clear();
            for (double i = a1; a1 + shag <= a2 + shag; a1 += shag)
            {
                Console.WriteLine(a1 + " С' = " + (a1 * 1.8 + 32) + " F'");
            }
        }
    }
}