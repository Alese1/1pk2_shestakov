using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10_08
{
    internal class Pet
    {
        #region поля
        private string name;
        private string kind;
        private string age;
        private string weight;
        private string health;
        #endregion

        #region св-ва
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
                else Console.WriteLine("ОШИБКА! имя отсудствует");

            }
        }
        public string Kind
        {
            get { return kind; }
            set
            {
                if (value != null)
                    kind = value;
                else
                    Console.WriteLine("ОШИБКА! вид животного отсутствует");
            }
        }
        public string Age
        {

            get { return age; }
            set
            {
                if (value != null)
                    age = value;
                else
                    Console.WriteLine("ОШИБКА! возрост отсутствует");
            }
        }
        public string Weight
        {
            get { return weight; }
            set
            {
                if (value != null)
                    weight = value;
                else
                    Console.WriteLine("ОШИБКА! вес животного отсутствует ");
            }
        }
        public string Health
        {
            get { return health; }
            set
            {
                if (value != null)
                    health = value;
                else
                    Console.WriteLine("ОШИБКА! отметка о состоянии ждоровья отсутствует");
            }
        }
        #endregion

        #region методы
        /// <summary>
        /// возвращает текущую информацию об объекте
        /// </summary>
        /// <returns>строка с информацией</returns>
        public string GetInfoAnimal()
        {
            return $"Кличка животного - {name}\nВид - {kind}" +
                $"\nВозраст - {age}\nВес - {weight}\nОтметка о состоянии здоровья - {health}";
        }
        /// <summary>
        /// изменение веса объекта
        /// </summary>
        /// <param name="a">новый вес объекта</param>
        public void WeightChange(string a)
        {
            Weight = a;
        }
        /// <summary>
        /// изменение состояния здоровья объекта
        /// </summary>
        /// <param name="a">новое состояние здоровья объекта</param>
        public void HealthChange(string a)
        {
            Health = a;
        }


        #endregion
        #region конструкторы
        /// <summary>
        /// конструктор создает объект животного со всеми св-вами
        /// </summary>
        /// <param name="name">кличка</param>
        /// <param name="kind">вид</param>
        /// <param name="age">возраст</param>
        /// <param name="weight">вес</param>
        /// <param name="health">отметка о здоровье</param>
        public Pet(string name, string kind, string age, string weight, string health)
        {
            this.name = name;
            this.kind = kind;
            this.age = age;
            this.weight = weight;
            this.health = health;
        }
        /// <summary>
        /// конструктор создает объект животного со всеми св-вами, кроме отметки о здоровье
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="kind">вид</param>
        /// <param name="age">возраст</param>
        /// <param name="weight">вес</param>
        public Pet(string name, string kind, string age, string weight)
        {
            this.name = name;
            this.kind = kind;
            this.age = age;
            this.weight = weight;
        }
        /// <summary>
        /// конструктор создает объект животного с именем, видом и возрастом
        /// остальные св-ва остаются незаполненными
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="kind">вид</param>
        /// <param name="age">возраст</param>
        public Pet(string name, string kind, string age)
        {
            this.name = name;
            this.kind = kind;
            this.age = age;
        }
        /// <summary>
        /// конструктор создает объект животного с именем и видом
        /// остальные св-ва остаются незаполненными
        /// </summary> 
        /// <param name="name">имя</param>
        /// <param name="kind">вид</param>
        public Pet(string name, string kind)
        {
            this.name = name;
            this.kind = kind;
        }
        /// <summary>
        /// конструктор создает объект животного только с именем
        /// остальные св-ва остаются незаполненными
        /// </summary>
        /// <param name="name">имя</param>
        public Pet(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// конструтор по умолчанию
        /// </summary>
        public Pet() { }
        #endregion
    }
}