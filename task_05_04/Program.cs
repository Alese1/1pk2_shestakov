namespace task_05_04
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
        диагональной (все элементы вне главной диагонали равны нулю)
        Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
        сообщение что матрица не является диагонально*/
        static void Main(string[] args)
        {
            int n;
            Random rnd = new Random();
            Console.WriteLine("видите длину матрицы");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
            }
            int[,] ints = new int[n, n];
            bool a = true;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rnd.Next(0, 2); 
                }
            }
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (i != j & ints[i, j] != 0)
                        a = false;
                }
            }
            {
                if (a == true);
            }
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (i == j);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(ints[i, j]);
                    Console.ResetColor();
                }


            }
        }
    }
}