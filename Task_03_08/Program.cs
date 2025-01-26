namespace Task_03_08
{
    internal class Program
    {
        /*Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.*/
        static void Main(string[] args)
        {
            int a = 20, b = 50;
            while (b != a)
            {
                if (b % 3 == 0 & b % 5 != 0)
                {
                    Console.WriteLine(b);

                }
                --b;

            }
        }
    }
}