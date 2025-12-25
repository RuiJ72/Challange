using System;

namespace AdventureGame
{
    // Class representing a hero
    public class Hero
    {
        // Properties
        public string Name { get; set; }
        public string Type { get; set; }

        // Constructor
        public Hero(string name, string type)
        {
            Name = name;
            Type = type.ToLower(); 
        }

        // Method to attack
        public void Attack()
        {
            string attackMove;

            // Determine attack based on hero type
            switch (Type)
            {
                case "mage":
                    attackMove = "magic";
                    break;
                case "warrior":
                    attackMove = "sword";
                    break;
                case "monk":
                    attackMove = "martial arts";
                    break;
                case "ninja":
                    attackMove = "shuriken";
                    break;
                default:
                    attackMove = "unknown attack";
                    break;
            }

            // Display attack message
            Console.WriteLine($"{Name} the {Type} attacked using {attackMove}!");
        }
    }
}
