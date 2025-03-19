namespace task_11_02
{
    internal class Program
    {
        /*Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
        меняет их местами. Проверьте, изменились ли значения переменных вне метода*/
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Ведите 1 число:");
            while (!int.TryParse(Console.ReadLine(), out num1))
                Console.WriteLine("Ошибка ввода");
            Console.WriteLine("Ведите 2 число:");
            while (!int.TryParse(Console.ReadLine(), out num2))
                Console.WriteLine("Ошибка ввода");
            Console.WriteLine();
            ReverseNumbers(ref num1, ref num2);
            Console.WriteLine($"\nЧисло 1 вне метода - {num1}\nЧисло 2 вне метода - {num2}");
        }
        /// <summary>
        /// замена чисел местами внутри и вне метода
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        static void ReverseNumbers(ref int num1, ref int num2)
        {
            int a = num2;
            num2 = num1;
            num1 = a;
            Console.WriteLine($"Число 1 внутри метода - {num1}\nЧисло 2 внутри метода - {num2}");
        }
    }
}