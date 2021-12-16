using System;
using System.Collections.Generic;

namespace EnglishtoSpanish
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionaries
            // Create a program that creates an English to Spanish dictionary.
            // 1. Store fun English words and store it's equivalent in Spanish.
            // 2. The program should allow you to look up for a definition of a word.
            // 3. You can print the current keys in the dictionary to the user.

            Dictionary<string, string> translation = new Dictionary<string, string>();
                translation.Add("Cheat sheet", "Shit shit");
                translation.Add("Where is the bathroom?", "¿Dónde está el baño?");
                translation.Add("Where is the nearest gas station?", "¿Dónde está la gasolinera más cercana?");
                translation.Add("Do you have a map?", "¿Tienes un mapa?");
                translation.Add("Where is the nearest restaurant?", "¿Dónde está el restaurante más cercano?");

                Console.WriteLine("Hello. Please press enter to continue to the Translation Menu: \n");
                Console.ReadKey();
                Console.WriteLine("What would you like to have translated?\nPress 1 for: 'Cheat sheet'\nPress 2 for: 'Where is the bathroom?'\nPress 3 for: 'Where is the nearest gas station?'\nPress 4 for: 'Do you have a map?'\nPress 5 for: 'Where is the nearest restaurant?'\nPress 6 to return to the main menu.");
            bool flag = false;
            do
            {
                try
                {
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine(translation["Cheat sheet"]);
                            flag = false;
                            break;
                        case 2:
                            Console.WriteLine(translation["Where is the bathroom?"]);
                            flag = false;
                            break;
                        case 3:
                            Console.WriteLine(translation["Where is the nearest gas station?"]);
                            flag = false;
                            break;
                        case 4:
                            Console.WriteLine(translation["Do you have a map?"]);
                            flag = false;
                            break;
                        case 5:
                            Console.WriteLine(translation["Where is the nearest restaurant?"]);
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Please enter 1 through 6.");
                            flag = false;
                            break;
                    }
                    Console.WriteLine("Thank you. Have a great day.");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.", e);
                    flag = true;
                }
            } while (flag);
        }
        #endregion
    }
}
