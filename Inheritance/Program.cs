using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //New instances
            Reptile crocodile1 = new Reptile();
            Bird pelican1 = new Bird();

            // Assigning value to class blueprint

            //Pelican1 & Adding Propertues from animal class

            pelican1.foodType = "Meat";
            pelican1.color = "White";
            pelican1.feet = 2;

            // Now adding properties from Bird Class

            pelican1.skinType = "Feathers";
            pelican1.mouthType = "Beak";

            //Crocodil1 & Adding properties from animal class

            crocodile1.foodType = "Meat";
            crocodile1.color = "green";
            crocodile1.feet = 4 ;

            // Now add from properties from Reptile class

            crocodile1.movement = "Crawl";
            crocodile1.weapon = "Jaws";

            // Returning & Printing everything to console

            // Pelican print
            Console.WriteLine("Pelican features:");
            Console.WriteLine($"Color : {pelican1.color}");
            Console.WriteLine($"Feet Count : {pelican1.feet}");
            Console.WriteLine($"Food Type : {pelican1.foodType}");
            Console.WriteLine($"Skin Type : {pelican1.skinType}");
            Console.WriteLine($"Mouth Type : {pelican1.mouthType}");

            Console.WriteLine("-----------------------------------------");
            // Crocodile Print
            Console.WriteLine("Crocodile features:");
            Console.WriteLine($"Color : {crocodile1.color}");
            Console.WriteLine($"Feet Count : {crocodile1.feet}");
            Console.WriteLine($"Food Type : {crocodile1.foodType}");
            Console.WriteLine($"Movement : {crocodile1.movement}");
            Console.WriteLine($"Weapon : {crocodile1.weapon}");
        }
    }
}
