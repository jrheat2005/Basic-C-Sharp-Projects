﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>();
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jess", "Bob", "Tom" };
            game.ListPlayer();
            Console.ReadLine();
            //games.Add(game);

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);

            //Console.ReadLine();
        }
    }
}
