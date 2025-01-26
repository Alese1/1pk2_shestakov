namespace Task_04_09
{
    internal class Program
    {
        /*В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран.
         * То есть найти и вывести уникальные элементы массива. (LINQ использовать нельзя)*/
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите количество чисел в массиве");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Ошибка ввода");
            Console.Clear();
            int[] ints = new int[a];
            Random rnd = new Random();
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(1, 10);
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________\nУникальные элементы массива:");
            for (int i = 0; i < ints.Length; i++)
            {
                bool b = true;
                for (int j = 0; j < a; ++j)   
                {
                    if (i != j & ints[i] == ints[j]) 
                    {
                        b = false;
                        break;
                    }
                }
                if (b == true)
                {
                    Console.WriteLine(ints[i]);
                }
            }
        }
    }
}