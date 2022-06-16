using System;

namespace Anketa
{
    class Program
    {
        static (string Name, string Surname, int Age, bool HavePet, int PetCount, string[] PetName) User()
        {
            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string Surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int Age = int.Parse(Console.ReadLine());

            byte PetCount = 0;
            string[] PetName = new string[PetCount];
            Console.Write("Есть ли у Вас домашние животные 'да/нет': ");
            string str = Console.ReadLine();
            bool HavePet = str == "да" || str == "Да" ? true : false;
            if (HavePet == true)
            {
                Console.Write("Количество петомцев: ");
                PetCount = byte.Parse(Console.ReadLine());
                PetName = Pet(PetCount);
            }
            return (Name, Surname, Age, HavePet, PetCount, PetName);
        }

        static string[] Pet(byte PetCount)
        {
            string[] PetList = new string[PetCount];
            Console.WriteLine("Введите имена петомцев:");
            for (int i = 0; i < PetList.Length; i++)
            {
                Console.Write((i + 1) + ".");
                PetList[i] = Console.ReadLine();
            }
            return PetList;
        }

        static void Main(string[] args)
        {
            var Person = User();

            Console.ReadKey();
        }
    }
}