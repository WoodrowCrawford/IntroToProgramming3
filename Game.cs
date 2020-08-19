using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 100.0f;
            float healthRegen = 20;
            string name = Console.ReadLine();
            bool maxLevelReached = false;
            int maxLevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine(health);
            health = health + healthRegen;
            Console.Write( name + " just healed " + healthRegen);



        }
    }
}
