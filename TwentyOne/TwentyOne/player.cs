﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class player
    {
        public player(string name, int beginnningBlance)
        {
            Hand = new List<card>();
            Balance = beginnningBlance;
            Name = name;
        }
        public List<card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlay { get; set; }
        public bool Stay { get; set; }
       
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return false;
            }
        }
        public static Game operator +(Game game, player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
