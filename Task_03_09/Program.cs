namespace Task_03_09
{
    internal class Program
{
    /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
    отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
    менее y рублей.
    Примеры
    входные данные
    100
    10
    200
    выходные данные
    8*/
    static void Main(string[] args)
    {
        double x, p, y, year = 0;
        Console.WriteLine("Введите сумму вклада");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Ошибка ввода");
        }
        Console.WriteLine("Введите процентное увеличение");
        while (!double.TryParse(Console.ReadLine(), out p))
        {
            Console.WriteLine("Ошибка ввода");
        }
        Console.WriteLine("Введите конечный вклад");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Ошибка ввода");
        }
        for (double i = x; x <= y; x += x * p / 100)
        {
            x = Math.Floor(x);
            ++year;
        }
        Console.Clear();
        Console.WriteLine(year);
    }
}
}