using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03022026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("=== Викторина ===");
            Console.WriteLine();

            // Въпрос 1
            Console.WriteLine("1. Коя е столицата на България?");
            string answer1 = Console.ReadLine();

            if (answer1.ToLower() == "софия")
            {
                Console.WriteLine("Правилен отговор!");
                score++;
            }
            else
            {
                Console.WriteLine("Грешен отговор!");
            }

            Console.WriteLine();

            // Въпрос 2
            Console.WriteLine("2. Колко е 5 + 7?");
            string answer2 = Console.ReadLine();

            if (answer2 == "12")
            {
                Console.WriteLine("Правилен отговор!");
                score++;
            }
            else
            {
                Console.WriteLine("Грешен отговор!");
            }

            Console.WriteLine();

            // Въпрос 3
            Console.WriteLine("3. Кой език използваме за .NET приложения?");
            string answer3 = Console.ReadLine();

            if (answer3.ToLower() == "c#" || answer3.ToLower() == "csharp")
            {
                Console.WriteLine("Правилен отговор!");
                score++;
            }
            else
            {
                Console.WriteLine("Грешен отговор!");
            }

            Console.WriteLine();
            Console.WriteLine($"Вашият резултат е: {score} от 3");

            Console.WriteLine("Натиснете клавиш за изход...");
            Console.ReadKey();
        }
    }
}
