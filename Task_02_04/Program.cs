namespace Task_02_04
{
    internal class Program
    {
        /* Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату) произведите
           расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об этом*/
        static void Main(string[] args)
        {
            int yearbirt, monthbirt, daybirt, curyear, curmonth, curday;
            Console.WriteLine("Введите свой год рождения");
            while (!int.TryParse(Console.ReadLine(), out yearbirt))
            {
                Console.WriteLine("Некорректный ввод, введите год рождения в виде числа");
            }

            Console.WriteLine("Введите свой месяц рождения(числом)");
            while (!int.TryParse(Console.ReadLine(), out monthbirt))
            {
                Console.WriteLine("Некорректный ввод, введите месяц рождения в виде числа");
            }
            Console.WriteLine("Введите свой день рождения");
            while (!int.TryParse(Console.ReadLine(), out daybirt))
            {
                Console.WriteLine("Некорректный ввод, введите день рождения в виде числа");
            }
            Console.WriteLine("Введите текущий год");
            while (!int.TryParse(Console.ReadLine(), out curyear))
            {
                Console.WriteLine("Некорректный ввод, введите текущий год  в виде числа");
            }
            Console.WriteLine("Введите текущий месяц(числом)");
            while (!int.TryParse(Console.ReadLine(), out curmonth))
            {
                Console.WriteLine("Некорректный ввод, введите текущий месяц в виде числа");
            }

            Console.WriteLine("Введите текущий день");
            while (!int.TryParse(Console.ReadLine(), out curday))
            {
                Console.WriteLine("Некорректный ввод, введите текущий день в виде числа");
            }

            int Age = curyear - yearbirt;
            if ((curmonth < monthbirt & Age == 18) || (curmonth == monthbirt & curday < daybirt))
                Age -= 1;
            if (Age >= 18)
                Console.WriteLine("Вы совершеннолетний");
            else
                Console.WriteLine("Вы несовершеннолетний");
        }
    }
}
