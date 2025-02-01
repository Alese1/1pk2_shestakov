namespace ConsoleApp4
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
        случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
        по следующему правилу:
        • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
        • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цвето*/
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Введите два числа: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, m];
            Random random_number = new Random();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random_number.Next(-99, 100);
                }
            }
            
            //Начинаем печатать массив
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0)
                    {
                        array[i, j] = array[i, j] * (-1);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (array[i, j] == 0)
                    {
                        array[i, j] = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}