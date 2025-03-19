namespace task_14_04
{
    internal class Program
    {
        /*Определите класс User, который будет иметь статическое свойство CurrentUser, 
        * представляющее текущего пользователя, и метод для его установки.*/
        static void Main(string[] args)
        {
            User user1 = new User();
            User.SetCurrentUser("Дима");
            Console.WriteLine(User.CurrentUser);
        }
    }
}