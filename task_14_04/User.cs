using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14_04
{
    class User
    {
        public static string CurrentUser
        {
            get; set;
        }
        /// <summary>
        /// запись текущего пользователя
        /// </summary>
        /// <param name="a">имя текущего пользователя</param>
        public static void SetCurrentUser(string a)
        {
            CurrentUser = a;
        }
    }
}