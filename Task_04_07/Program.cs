namespace Task_04_07
{
    internal class Program
    {
        /*В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
        отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
        мальчиков и девочек. При выводе избавиться от отрицательных значений.
        */
        static void Main(string[] args)
        {
            int[] classf = new int[30];
            int man = 0, woman = 0, sredwoman = 0, sredman = 0;
            Random rnwoman = new Random();
            for (int i = 0; i < classf.Length; i++)
            {
                if (i % rnwoman.Next(1, 5) == 0)
                {
                    classf[i] = rnwoman.Next(140, 200);
                    ++woman; sredwoman += classf[i];
                }
                else
                {
                    classf[i] = -rnwoman.Next(150, 200);
                    ++man; sredman += classf[i];
                }

            }
            Console.WriteLine($"Количество мальчиков - {man}\nКоличество девочек - {woman}\n" +
                $"Средний рост мальчиков - {(-sredman) / man }\n" +
                $"Средний рост девочек - {sredwoman / woman}");
        }
    }
}