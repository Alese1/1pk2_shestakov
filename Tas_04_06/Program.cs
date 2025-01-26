namespace Task_04_06
{
    internal class Program
    {
        /*Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
        модулю были разными. Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
        двух равных по модулю. В полученном массиве найти наибольшее по модулю число.*/
        static void Main(string[] args)
        {
            int a, maxi = 0;

            Console.WriteLine("Введите количество чисел в массиве");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Ошибка ввода");
            Console.Clear();
            Random rnd = new Random();
            int[] numbers = new int[a];
            for (int i = 0; i < a; ++i)
            {
                int vmassiv;
                bool uni;
                do               //проверяем на уникальность
                {
                    vmassiv = rnd.Next(-a, a + 1);
                    uni = true;
                    for (int j = 0; j < i; ++j)
                    {
                        if (Math.Abs(numbers[j]) == Math.Abs(vmassiv) || numbers[j] == vmassiv)
                        {
                            uni = false;
                            break;

                        }
                    }
                } while (!uni);
                numbers[i] = vmassiv;
                Console.Write(numbers[i] + " ");

            }
            Console.WriteLine();
            for (int i = 0; i < a; ++i) //макс по модулю
            {
                if (Math.Abs(maxi) < Math.Abs(numbers[i]))
                {
                    maxi = Math.Abs(numbers[i]);
                }
            }
            Console.WriteLine($"Максимальное по модулю число в массиве - {maxi}");




        }
    }
}