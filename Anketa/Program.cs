using System;

namespace Anketa
{
    class Program
    {
        static (string Name, string Surname, int Age, bool HavePet, int PetCount, string[] PetName, int ColorCount, string[] FavColors) User()
        {
            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string Surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int Age = CheckValue();

            int PetCount = 0;
            string[] PetName = new string[PetCount];

            Console.Write("Есть ли у Вас домашние животные 'да/нет': ");
            string str = Console.ReadLine();
            bool HavePet = str == "да" || str == "Да" ? true : false;

            if (HavePet == true)
            {
                Console.Write("Количество петомцев: ");
                PetCount = CheckValue();
                PetName = Pet(PetCount);
            }

            Console.Write("Введите количество любимых цветов: ");
            int ColorCount = CheckValue();
            string[] FavColors = Colors(ColorCount);

            return (Name, Surname, Age, HavePet, PetCount, PetName, ColorCount, FavColors);
        }

        static string[] Pet(int PetCount)
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

        static string[] Colors(int ColorCount)
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

        static int CheckValue()
        {
            do
            {
                string Value = Console.ReadLine();
                int.TryParse(Value, out int ModifValue);

                if (ModifValue <= 0)
                {
                    Console.Write("Ошибка! Введите корректное значение: ");
                    continue;
                }
                else
                    return ModifValue;

            } while (true);
        }

        static void Main(string[] args)
        {
            var Person = User();

            Console.ReadKey();
        }
    }
}