using System;

namespace Anketa
{
    class Program
    {
        static (string Name, string Surname, byte Age, bool HavePet, byte PetCount, string[] PetName, byte ColorCount, string[] Colors) User()
        {
            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string Surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            byte Age = byte.Parse(Console.ReadLine());

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

            Console.Write("Введите количество любимых цветов: ");
            byte ColorCount = byte.Parse(Console.ReadLine());
            string[] FavColors = Colors(ColorCount);

            return (Name, Surname, Age, HavePet, PetCount, PetName, ColorCount, FavColors);
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

        static string[] Colors(byte ColorCount)
        {
            string[] ColorList = new string[ColorCount];
            Console.WriteLine("Введите любимые цвета:");
            for (int i = 0; i < ColorList.Length; i++)
            {
                Console.Write((i + 1) + ".");
                ColorList[i] = Console.ReadLine();
            }
            return ColorList;
        }

        static void Main(string[] args)
        {
            var Person = User();

            Console.ReadKey();
        }
    }
}