namespace task_11_04
{
    internal class Program
    {
        /*Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
        их среднее значение. Используйте ключевое слово params*/
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размер массива:");
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.WriteLine("Ошибка ввода");
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите число {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Value(numbers));
        }
        /// <summary>
        /// нахождение среднего значения по массиву чисел
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <returns>среднее значение</returns>
        static double Value(params int[] array)
        {
            double summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            return summ / array.Length;
        }
    }
}