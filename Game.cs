using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("Hey there! You probably have no idea where you are lol");
            Console.WriteLine("Well long story short, you are in a game. But of course you knew that right?");
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("But hey! Free game! So what do you want to be called?");
            string name = Console.ReadLine();
      
    
            Console.WriteLine(name  + ",huh? That's a great name!");
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


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
                Console.Clear();
                Console.WriteLine(" A knight? This class can take a lot of hits");


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
            Console.WriteLine("Damage Output: " + damage);
            Console.WriteLine
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
