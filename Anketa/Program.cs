using System;

namespace Anketa
{
    class Program
    {
        static void PrintData((string Name, string Surname, int Age, string[] PetName, string[] FavColors) User)
        {
            Console.WriteLine("\n\n---------------АНКЕТА--------------");
            Console.WriteLine($"Имя: {User.Name}");
            Console.WriteLine($"Фамилия: {User.Surname}");
            Console.WriteLine($"Возраст: {User.Age}");

            if (User.PetName.Length != 0)
            {
                Console.WriteLine("Клички петомцев");
                foreach (var item in User.PetName)
                    Console.WriteLine("  " + item);
            }
            else
                Console.WriteLine("Нет петомцев");

            Console.WriteLine("Любимые цвета");
            foreach (var item in User.FavColors)
                Console.WriteLine("  " + item);
        }
        static (string Name, string Surname, int Age, string[] PetName, string[] FavColors) UserData()
        {

            (string Name, string Surname, int Age, string[] PetName, string[] FavColors) User;

            Console.Write("Введите имя: ");
            User.Name = CheckString();

            Console.Write("Введите фамилию: ");
            User.Surname = CheckString();

            Console.Write("Введите возраст: ");
            User.Age = CheckNumber();

            int PetCount = 0;
            User.PetName = new string[PetCount];

            Console.Write("Есть ли у Вас домашние животные 'да/нет': ");
            string str;
            bool HavePet;

            while (true)
            {
                str = Console.ReadLine();

                if (str == "да" || str == "Да")
                {
                    HavePet = true;
                    break;
                }
                else if (str == "нет" || str == "Нет")
                {
                    HavePet = false;
                    break;
                }
                else
                {
                    Console.Write("Ошибка! Введите 'да' или 'нет': ");
                    continue;
                }
            }

            if (HavePet == true)
            {
                Console.Write("Количество петомцев: ");
                PetCount = CheckNumber();
                Console.WriteLine("Введите имена петомцев");
                User.PetName = Data(PetCount);
            }

            Console.Write("Введите количество любимых цветов: ");
            int ColorCount = CheckNumber();
            Console.WriteLine("Введите любимые цвета");
            User.FavColors = Data(ColorCount);

            return User;
        }

        static string[] Data(int Count)
        {
            string[] List = new string[Count];

            for (int i = 0; i < List.Length; i++)
            {
                Console.Write((i + 1) + ". ");
                List[i] = CheckString();
            }

            return List;
        }

        static int CheckNumber()
        {
            do
            {
                string Value = Console.ReadLine();
                int.TryParse(Value, out int ModifValue);

                if (ModifValue <= 0)
                {
                    Console.Write("Ошибка! Введите число: ");
                    continue;
                }
                else
                    return ModifValue;

            } while (true);
        }

        static string CheckString()
        {
            do
            {
                string str = Console.ReadLine();
                bool check = int.TryParse(str, out int ModifValue);

                if (check == true)
                {
                    Console.Write("Ошибка! Введите строку: ");
                    continue;
                }
                else
                    return str;

            } while (true);
        }

        static void Main(string[] args)
        {
            var Person = UserData();

            PrintData(Person);

            Console.ReadKey();
        }
    }
}