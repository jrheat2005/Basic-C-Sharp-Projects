﻿using System;
using System.Collections.Generic;

namespace Twenty_One
{
    public class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public void ListPlayer()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}