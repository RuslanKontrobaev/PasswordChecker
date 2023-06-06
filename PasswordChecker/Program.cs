using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводимый пароль обязан:\n" +
                "1. Содержать символы верхнего и нижнего регистров.\n" +
                "2. Состоять только из цифр, букв латинского алфавита, нижнего подчеркивания, тире, точки.\n" +
                "3. В начале и в конце пароля должны находиться латинский символы.\n" +
                "4. Длина пароля от 8 до 25 символов.\n");

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
            string pattetn = @"^[a-zA-Z][\w.-]{6,23}[a-zA-Z]$";
            Regex regex = new Regex(pattetn);

            return regex.IsMatch(password);
        }
    }
}
