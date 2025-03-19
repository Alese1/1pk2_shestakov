using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13_03
{
    internal class Car
    {
        #region поля
        private string carnumber;
        private string kind;
        private string colour;
        private int currentspeed;
        #endregion

        #region св-ва
        public string Carnumber
        {

            get { return carnumber; }
            set
            {
                if (value != null)
                    carnumber = value;
                else
                    Console.WriteLine("Отсутствует номер машины");
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
                    Console.WriteLine("Отсутствует марка машины");
            }
        }
        public string Colour
        {

            get { return colour; }
            set
            {
                if (value != null)
                    colour = value;
                else
                    Console.WriteLine("Отсутствует цвет машины");
            }
        }
        public int Currentspeed
        {

            get { return currentspeed; }
            set
            {
                if (value != null)
                    currentspeed = value;
                else
                    Console.WriteLine("Отсутствует текущая скорость машины");
            }
        }
        #endregion
        #region методы
        /// <summary>
        /// равноускоренное увеличение начальной скорости
        /// </summary>
        /// <param name="a">начальная скорость</param>
        public void CarGo(int a)
        {
            if (a < 80)
                Console.WriteLine($"Начато ускорение,текущая скорость - {a}");
            while (a < 80)
            {
                a += 5;
                Console.WriteLine($"Текущая скорость - {a}");
            }
            Currentspeed = a;
        }
        /// <summary>
        /// уменьшение скорости авто и 
        /// его остановка
        /// </summary>
        /// <param name="a"></param>
        public void CarStop(int a)
        {
            Console.WriteLine($"Начато торможение,текущая скорость - {a}");
            while (a > 0)
            {
                a -= 20;
                if (a < 0)
                    a = 0;
                Console.WriteLine($"Текущая скорость - {a}");
            }

            Currentspeed = a;
        }
        #endregion
        #region конструкторы
        /// <summary>
        /// конструктор создает машину со всеми св-вами
        /// </summary>
        /// <param name="carnumber">номер машины</param>
        /// <param name="kind">марка</param>
        /// <param name="colour">цвет</param>
        /// <param name="currentspeed">текущая скорость</param>
        public Car(string carnumber, string kind, string colour, int currentspeed)
        {
            this.carnumber = carnumber;
            this.kind = kind;
            this.colour = colour;
            this.currentspeed = currentspeed;
        }
        /// <summary>
        /// конструктор создает машину со всеми св-вами, кроме цвета
        /// </summary>
        /// <param name="carnumber">номер</param>
        /// <param name="kind">марка</param>
        /// <param name="currentspeed">тек.скорость</param>
        public Car(string carnumber, string kind, int currentspeed)
        {
            this.carnumber = carnumber;
            this.kind = kind;
            this.currentspeed = currentspeed;
        }
        /// <summary>
        /// конструктор создает машину с номером и скоростью,
        /// остальные св-ва незаполнены
        /// </summary>
        /// <param name="carnumber">номер</param>
        /// <param name="currentspeed">скорость</param>
        public Car(string carnumber, int currentspeed)
        {
            this.carnumber = carnumber;
            this.currentspeed = currentspeed;
        }
        /// <summary>
        /// конструктор создает машину со скоростью,
        /// остальные св-ва незаполнены
        /// </summary>
        /// <param name="currentspeed">скорость</param>
        public Car(int currentspeed)
        {
            this.currentspeed = currentspeed;
        }
        /// <summary>
        ///конструктор создает машину с номером и цветом,
        /// остальные св-ва незаполнены
        /// </summary>
        /// <param name="carnumber">номер</param>
        /// <param name="colour">цвет</param>
        public Car(string carnumber, string colour)
        {
            this.carnumber = carnumber;
            this.colour = colour;
        }
        /// <summary>
        ///конструктор создает машину с номером,
        /// остальные св-ва незаполнены 
        /// </summary>
        /// <param name="carnumber"></param>
        public Car(string carnumber)
        {
            this.carnumber = carnumber;
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Car() { }
        #endregion
    }
}