namespace Task_02_02
{
    /*Найти значение выражения при 
     * a = 8, b = 14, с = π/4
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 8; double b = 14; double c = (Math.PI / 4);
            double firstd = Math.Pow((b + Math.Pow((a - 1), 1.0 / 3.0)), 1.0 / 4.0);
            double secondd = Math.Abs(a - b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c));
            Console.WriteLine(firstd / secondd);
        }
    }
}
