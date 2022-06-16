using System;

namespace Anketa
{
    class Program
    {
        static (string Name, string Surname, int Age, int PetCount) User()
        {
            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string Surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int Age = int.Parse(Console.ReadLine());

            int PetCount = 0;
            Console.Write("Есть ли у Вас домашние животные 'да/нет': ");
            string str = Console.ReadLine();
            bool HavePet = str == "да" || str == "Да" ? true : false;
            if (HavePet == true)
            {

            }
            return (Name, Surname, Age, PetCount);
        }

        static void Main(string[] args)
        {
            var Person = User();

            Console.ReadKey();
        }
    }
}