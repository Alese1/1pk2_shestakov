namespace task_11_08
{
    internal class Program
    {
        /*Использование params и out: Напишите метод, который принимает переменное количество
        чисел и возвращает их сумму и максимальное значение через выходные параметры (out).*/
        static void Main(string[] args)
        {
            int summ, max;
            NumbersSummAndMax(out summ, out max, 1, 6, 8, 9, 10, 15, 20, 13);
            Console.WriteLine($"Сумма чисел = {summ}\nМаксимальное число = {max}");
        }
        static void NumbersSummAndMax(out int summ, out int max, params int[] numbers)
        {
            summ = 0; max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                summ += numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
            }
        }
    }
}