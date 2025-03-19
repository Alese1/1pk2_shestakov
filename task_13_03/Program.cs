namespace task_13_03
{
    internal class Program
    {
        /*создайте класс автомобиля
         свойства:
         номер авто, марка, цвет, текущая скорость
         методы:
         езда (симитировать равномерное ускорение скорости автомобиля)
         торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
         конструторы
         предусмотрите разные варианты инициализации объектов*/
        static void Main(string[] args)
        {
            Console.WriteLine("Машина 1");
            Car car1 = new Car(); // машина 1
            car1.Carnumber = "OK123I";
            car1.Kind = "Aurus";
            car1.Colour = "Черный";
            car1.Currentspeed = 21;

            Console.WriteLine("Журнал скорости:");
            car1.CarGo(car1.Currentspeed);
            car1.CarStop(car1.Currentspeed);

            Console.WriteLine("\n\n");
            Console.WriteLine("Машина 2");
            Car car2 = new Car(); //машина 2 c отсутствующими параметрами
            car2.Carnumber = null;
            car2.Kind = null;
            car2.Colour = null;
            car2.Currentspeed = 120;
            Console.WriteLine("Журнал скорости:");
            car1.CarGo(car2.Currentspeed);
            car1.CarStop(car2.Currentspeed);

        }
    }
}