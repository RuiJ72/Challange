using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure Game!");

            // Ask user for hero details
            Console.Write("Enter hero name: ");
            string heroName = Console.ReadLine();

            string heroType;
            while (true)
            {
                Console.Write("Enter hero type (mage, warrior, monk, ninja): ");
                heroType = Console.ReadLine().ToLower();

                // Validate input
                if (heroType == "mage" || heroType == "warrior" || heroType == "monk" || heroType == "ninja")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid type. Please enter one of: mage, warrior, monk, ninja.");
                }
            }

            // Create hero instance
            Hero playerHero = new Hero(heroName, heroType);

            // Attack
            playerHero.Attack();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
