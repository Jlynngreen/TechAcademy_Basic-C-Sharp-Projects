﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class card
    {
        public string Suit { get; set; }
        public string Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs, 
        Diamonds,
        Hearts,
        Spades,
    }
    public enum Face
    {
        Two,
        Three, 
        Four, 
        Five, 
        Six,
        Seven,
        Eight,
        Nine,
        Ten

    }
}
