namespace task_11_06
{
    internal class Program
    {
       /*Передача массива по значению: Напишите метод, который принимает массив целых чисел и
        изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный массив вне метода.*/
    
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество чисел в массиве:");
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.WriteLine("Ошибка ввода");
            int[] numbers = new int[n];
            Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите число {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Изначальный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\nМассив внутри метода:");
            Array(numbers);
        }
        /// <summary>
        /// изменение элементов массива на +1
        /// </summary>
        /// <param name="array">исходный массив</param>
        static void Array(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
                Console.Write(array[i] + " ");
            }
        }
    }
}