namespace Task_10_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать Метод ArrayGeneration не возвращающий значения, 
         * принимает целое число n, выводит на консоль сгенерированный 
         * массив размерности n*n.*/

            static void Main(string[] args)
            {
                Console.WriteLine("Введите размер массива ");
                int a = int.Parse(Console.ReadLine());
                
                Console.Clear();
                ArrayGeneration(a);
            }
            /// <summary>
            /// производит генерацию и вывод на консоль массива
            /// </summary>
            /// <param name="n">размер массива</param>

            static void ArrayGeneration(int a)
            {
                int[,] array = new int[a, a];
                Random rnd = new Random ();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rnd.Next(0, 10);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
