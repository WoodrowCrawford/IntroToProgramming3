using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.Write("Hello traveler! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name  + ",huh? That's a great name!");
            Console.WriteLine("Welcome " + name + "! " + "Please select a number for a role");
            Console.WriteLine("1. knight");
            Console.WriteLine("2. mage");
            Console.WriteLine("3. archer");
            // This variable is used to store health
            float health = 100.0f;
            //This variable is used to store mana
            float mana = 20.0f;
            // This value is used to heal the player
            float healthRegen = 20;
            float manaRegen = 5;
            float damage = 20;
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                Console.WriteLine(" A knight? Not my preference but oh well.");

                health = 200;
                mana = 20;
                damage = 10;
            }
            else if (input == '2')
            {
                Console.WriteLine(" A mage? I love that class!");
                health = 100;
                mana = 50;
                damage = 4;
            }
            else if (input == '3')
            {
                Console.WriteLine(" An archer? I hope you have good aim lmao");
            }
            Console.WriteLine("That's a great role!");
            Console.WriteLine("What about your favorite element?");
            string element = Console.ReadLine();
            string role = ("none");       
            bool maxLevelReached = false;
            int maxDamage = 20;
            int level = 1;
            bool ready = true;
            Console.WriteLine(health);
            health = health + healthRegen; 
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Mana: " + mana);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role:  ");
            Console.WriteLine("Favorite Element: " + element);
            Console.WriteLine("Damage Output: " + damage);
            Console.WriteLine(name + " just healed " + healthRegen + " !");
            //Create an application that gets the users name 
            //along with an additional input. Print the user's name and input
            //to the console along with their stats. Must use all data types.
            Console.WriteLine("Oh no a spider suddenly appeared!! What do you want to do?");          
            Console.WriteLine("1. Scream");
            Console.WriteLine("2. Talk to it");
            Console.WriteLine("3 VIBE WITH IT");
            char input2 = Console.ReadKey().KeyChar;
            if (input2 == '1')
            {               
                Console.Clear();
                Console.WriteLine("CONGRATS NOTHING HAPPENED!!!!");
                Console.WriteLine("...");

            }
            else if (input2 == '2')
            {
                Console.WriteLine("cool");
            }




        }
    }
}
