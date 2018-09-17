﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Fruit
    {
        public static Dictionary<string, int> FindFruit = new Dictionary<string, int>
        {
            { "Cherry", 100 },
            { "Strawberry", 300 },
            { "Orange", 500 },
            { "Apple", 700 },
            { "Melon", 1000 },
            { "Galaxian", 2000 },
            { "Bell", 3000 },
            { "Key", 5000 }
        };

        public static int GetBonus(string fruit)
        {
            int result;
            if(FindFruit.TryGetValue(fruit, out result))
            {
                return result;
            }

            else
            {
                return 0;
            }
        }



    }
}
