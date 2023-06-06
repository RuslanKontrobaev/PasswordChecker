using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            bool isValid = ValidatePassword(password);

            if (isValid)
            {
                Console.WriteLine("Пароль сооствествует требованиям");
            }
            else
            {
                Console.WriteLine("Пароль не сооствествует требованиям");
            }

            Console.ReadLine();
        }

        static bool ValidatePassword(string password)
        {

        }
    }
}
