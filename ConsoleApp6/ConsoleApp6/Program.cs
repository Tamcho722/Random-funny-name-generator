using System;

namespace RandomFunnyNameGenerator
{
    class Program
    {
        // Масиви с разнообразни първи имена и фамилии
        private static string[] firstNames = { "Боб", "Сандра", "Петър", "Лиза", "Михаил", "Радо", "Александър", "Иван", "Анна", "Даниела", "Тим" };
        private static string[] lastNames = { "Патладжан", "Лудошар", "Банан", "Пипер", "Чушки", "Зеле", "Пух", "Джъмбо", "Гъба", "Тиква", "Чесън" };

        private static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Натиснете 'Enter', за да генерирате ново смешно име.");

            while (true)
            {
                string userInput = Console.ReadLine();

                // Генерираме ново име, ако потребителят натисне 'Enter'
                if (userInput == "")
                {
                    GenerateRandomName();
                    Console.WriteLine("Натиснете 'Enter', за да генерирате ново име или 'q' за изход:");
                }
                // Излизане от програмата ако потребителят натисне 'q'
                if (userInput.ToLower() == "q")
                {
                    Console.WriteLine("Програмата приключи.");
                    break;
                }
            }
        }

        // Функция за генериране на случайно име
        private static void GenerateRandomName()
        {
            int firstNameIndex = random.Next(firstNames.Length);   // Избор на случайно първо име
            int lastNameIndex = random.Next(lastNames.Length);     // Избор на случайна фамилия

            string randomName = firstNames[firstNameIndex] + " " + lastNames[lastNameIndex];
            Console.WriteLine($"Случайно име: {randomName}");
        }
    }
}

