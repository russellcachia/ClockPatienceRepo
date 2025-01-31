﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockPatience
{
    class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }

        public Card(string rank, string suit) 
        {
            Rank = rank;
            Suit = suit;
        }

        //add method to convert card rank to numerical value (for placement)
        public int GetPileIndex()
        {
            switch(Rank)
            {
                case "A": return 1; //ace
                case "2": return 2;
                case "3": return 3;
                case "4": return 4;
                case "5": return 5;
                case "6": return 6;
                case "7": return 7;
                case "8": return 8;
                case "9": return 9;
                case "T": return 10; //ten
                case "J": return 11; //jack
                case "Q": return 12; //queen
                case "K": return 13; //king

                default: return 0;
            }
        }

        public override string ToString() 
        {
            return $"{Rank}{Suit}";
        }
    }
}
