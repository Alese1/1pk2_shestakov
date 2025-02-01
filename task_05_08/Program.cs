namespace Task_05_08
{
    internal class Program
    {
        /* Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
        произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
        результирующий массив) 
        Вывести результирующий массив*/
        static void Main(string[] args)
        {
            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];
            int[,] c = new int[10, 10];
            Random rnd = new Random();
            Console.WriteLine("Заданные массивы:\n");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                    b[i, j] = rnd.Next(1, 10);
                    c[i, j] = a[i, j] * b[i, j];
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("\t");
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Результирующий массив:\n");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}