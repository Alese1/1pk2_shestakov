namespace task_11_03
{
    internal class Program
    {
        /*Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
        выходной параметр количество гласных и согласных букв в этой строке*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string a = Console.ReadLine();
            int glasnye, soglasnye;
            CountOfChar(a, out glasnye, out soglasnye);
            Console.WriteLine($"Кол-во гласных - {glasnye}\nКол-во согласных - {soglasnye}");
        }
        /// <summary>
        /// определение количества гласных и согласных в строке
        /// </summary>
        /// <param name="a">строка</param>
        /// <param name="glasnye">кол-во гласных</param>
        /// <param name="soglasnye">кол-во согласных</param>
        static void CountOfChar(string a, out int glasnye, out int soglasnye)
        {
            glasnye = 0; soglasnye = 0;
            char[] chars = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'А', 'Е', 'Ё', 'И', 'О', 'У',
                'Ы', 'Э', 'Ю', 'Я', 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'Y', 'y' };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != ' ') // не знаю как решить не используя строки
                {
                    bool flagglsn = false;
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if (a[i] == chars[j])
                        {
                            flagglsn = true;
                            break;
                        }
                    }
                    if (flagglsn)
                        glasnye++;
                    else
                        soglasnye++;
                }

            }
        }
    }
}