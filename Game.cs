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
            Console.WriteLine("Welcome " + name + "! " + "Please input a role");
            string role = (Console.ReadLine());
            // This variable is used to store health
            float health = 100.0f;
            // This value is used to heal the player
            float healthRegen = 20;
            bool maxLevelReached = false;
            int maxLevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine(health);
            health = health + healthRegen;
            Console.WriteLine(name + " just healed " + healthRegen + " !");
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role:  " + role);
            //Create an application that gets the users name 
            //along with an additional input. Print the user's name and input
            //to the console along with their stats. Must use all data types.
            



        }
    }
}
