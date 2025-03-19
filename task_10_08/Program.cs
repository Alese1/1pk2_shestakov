namespace task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает одномерный массив и число для поиска,
         верните индекс искомого элемента в массиве. Если элемента нет – верните индекс = -1*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.WriteLine("Ошибка ввода");
            int[] numbers = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 10);
            }
            Console.Clear();
            Console.WriteLine("Введите искомое число:");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Ошибка ввода");
            Console.Clear();
            Console.WriteLine($"Индекс:\n{Found(a, numbers)}");
        }
        /// <summary>
        /// производит поиск числа и вывод его индекса
        /// </summary>
        /// <param name="a">искомое число</param>
        /// <param name="array">массив, в котором ищется число</param>
        /// <returns>индекс искомого числа или -1</returns>
        static int Found(int a, int[] array)
        {
            int foundindex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                {
                    foundindex = i;
                    break;
                }
            }
            return foundindex;
        }

    }
}