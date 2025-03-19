namespace task_10_07
{
    internal class Program
    {
        /*Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерныймассив (состоящийиз символов русского алфавита)
         * и выведите на консоль данный массив с помощью другого метода (которыйпринимает данный массив в качестве параметра)*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            char[,] Alphabet = AlphabetGeneration(n);
            PrintArray(Alphabet);
        }
        /// <summary>
        /// генерация массива алфавита
        /// </summary>
        /// <param name="n">размер массива</param>
        /// <returns>символьный двумерный массив</returns>
        static char[,] AlphabetGeneration(int n)
        {
            char[,] CharAlphabet = new char[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    CharAlphabet[i, j] = (char)('а' + rnd.Next(0, 32));
                }
            }
            return CharAlphabet;
        }
        /// <summary>
        /// вывод на консоль массива
        /// </summary>
        /// <param name="array">массив</param>
        static void PrintArray(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}