namespace Task_04_10
{
    internal class Program
    {
        /*Заполнить массив из 10 элементов случайными числами в интервале [-10..10] и сделать реверс элементов отдельно для 1-ой и 2-ой половин массива. 
        Реверс реализовать через цикл. 
        Стандартные методы класса Array использовать нельзя. 
        Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
        Результат: [4,0,-10,2,5,-7,9,2,7,-6]*/
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            Random random = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-10, 10);
                Console.Write(a[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("-------------------------\nРезультат реверса:");
            for (int i = 4; i >= 0; --i)
            {
                for (int j = 0; j < 5; j++)
                {
                    b[j] = a[i];
                }
                Console.Write(b[i] + " ");
            }
            for (int i = 9; i >= 5; --i)
            {
                for (int j = 5; j < 10; j++)
                {
                    b[j] = a[i];
                }
                Console.Write(b[i] + " ");
            }
        }
    }
}