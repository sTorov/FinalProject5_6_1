using System;

namespace Anketa
{
    class Program
    {
        static void PrintData((string Name, string Surname, int Age, bool HavePet, int PetCount, string[] PetName, int ColorCount, string[] FavColors) User)
        {
            Console.WriteLine("\n\n---------------АНКЕТА--------------");
            Console.WriteLine($"Имя: {User.Name}");
            Console.WriteLine($"Фамилия: {User.Surname}");
            Console.WriteLine($"Возраст: {User.Age}");
            Console.WriteLine($"Наличие петомцев: {User.HavePet}");
            if (User.HavePet == true)
            {
                Console.WriteLine($"Количество петомцев: {User.PetCount}");
                Console.WriteLine("Клички петомцев");
                foreach (var item in User.PetName)
                    Console.WriteLine("  " + item);
            }
            Console.WriteLine($"Количество любимых цветов: {User.ColorCount}");
            Console.WriteLine("Любимые цвета");
            foreach (var item in User.FavColors)
                Console.WriteLine("  " + item);
        }
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
                Console.WriteLine("Введите имена петомцев");
                PetName = Data(PetCount);
            }

            Console.Write("Введите количество любимых цветов: ");
            int ColorCount = CheckValue();
            Console.WriteLine("Введите любимые цвета");
            string[] FavColors = Data(ColorCount);

            return (Name, Surname, Age, HavePet, PetCount, PetName, ColorCount, FavColors);
        }

        static string[] Data(int Count)
        {
            string[] List = new string[Count];

            for (int i = 0; i < List.Length; i++)
            {
                Console.Write((i + 1) + ".");
                List[i] = Console.ReadLine();
            }

            return List;
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

            PrintData(Person);

            Console.ReadKey();
        }
    }
}