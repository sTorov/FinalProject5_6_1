using System;

namespace Anketa
{
    class Program
    {
        static (string Name, string Surname, int Age) User()
        {
            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string Surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int Age = int.Parse(Console.ReadLine());

            return (Name, Surname, Age);
        }

        static void Main(string[] args)
        {
            var Person = User();

            Console.ReadKey();
        }
    }
}