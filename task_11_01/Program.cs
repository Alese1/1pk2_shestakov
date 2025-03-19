namespace task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их
        местами. Проверьте, изменились ли значения переменных вне метода*/
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
            ReverseNumbers(num1, num2);
            Console.WriteLine($"\nЧисло 1 вне метода - {num1}\nЧисло 2 вне метода - {num2}");
        }
        /// <summary>
        /// замена чесел местами внутри метода
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        static void ReverseNumbers(int num1, int num2)
        {
            int a = num2;
            num2 = num1;
            num1 = a;
            Console.WriteLine($"Число 1 внутри метода - {num1}\nЧисло 2 внутри метода - {num2}");
        }
    }
}