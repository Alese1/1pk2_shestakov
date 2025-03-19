using task_10_08;

namespace task_13_02
{
    internal class Program
    {
        /*создать класс питомца
        свойства:
        кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
        методы:
        вывод информации об объекте
        изменение значения веса животного
        изменение отметки о состоянии здоровья
        конструторы:
        предусмотрите разные варианты инициализации объектов*/
        static void Main(string[] args)
        {
            Pet pet1 = new Pet(); //объект 1
            pet1.Name = "Малышь ";
            pet1.Kind = "Собока";
            pet1.Age = "4";
            pet1.Weight = "11";
            pet1.Health = "Здоров";
            Console.WriteLine(pet1.GetInfoAnimal());
            Console.WriteLine();
            //изменение веса и сост здоровья
            pet1.WeightChange("25");
            pet1.HealthChange("Не здоров");
            Console.WriteLine(pet1.GetInfoAnimal());
            Console.WriteLine();
        }
    }
}