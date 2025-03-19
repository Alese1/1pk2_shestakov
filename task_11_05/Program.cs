namespace task_11_05
{
    internal class Program
    {
        /*Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
        возвращает их сумму и произведение через выходные параметры(out).*/

        static void Main()
        {
            double a, b, summ, proizv;
            Console.WriteLine("Введите число 1:");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Ошибка ввода");
            Console.WriteLine("Введите число 2:");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Ошибка ввода");
            Summ(ref a, ref b, out summ, out proizv);
            Console.WriteLine($"Сумма чисел: {summ}\nПроизведение чисел: {proizv}");
        }
        /// <summary>
        /// вычисление суммы и произведения чисел
        /// </summary>
        /// <param name="a">число 1</param>
        /// <param name="b">число 2</param>
        /// <param name="summ">сумма</param>
        /// <param name="proizv">произведение</param>
        static void Summ(ref double a, ref double b, out double summ, out double proizv)
        {
            summ = a + b;
            proizv = a * b;
        }
    }
}