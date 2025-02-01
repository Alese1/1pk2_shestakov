namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] array_1 = new char[3, 3];
            char[,] array_2 = new char[3, 3];
            string[] help = new string[6];
            bool[,] equals_array = new bool[3, 3];
            bool equals = true;
           
            Console.WriteLine("Введите два массива размера 3*3, разделённые несколькими пробелами:");
            for (int i = 0; i < 3; i++)
            {
                help = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < 3; j++)
                {
                    array_1[i, j] = help[j][0];
                }
                for (int j = 0; j < 3; j++)
                {
                    array_2[i, j] = help[j + 3][0];
                }
            }
            //Заканчиваем ввод двух массивов
            //Начинаем сравнение двух массивов
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array_1[i, j] == array_2[i, j])
                    {
                        equals_array[i, j] = true;
                    }
                    else
                    {
                        equals = false;
                        equals_array[i, j] = false;
                    }
                }
            }
            //Заканчиваем сравнение массивов
            //Начинаем вывод
            Console.WriteLine("=>");
            if (equals)
            {
                Console.WriteLine("Массивы равны");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (equals_array[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(array_1[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(' ');
                    }
                    Console.Write("  ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (equals_array[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(array_2[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}