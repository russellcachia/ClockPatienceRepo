﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockPatience
{
    internal class Deck
    {
        private Stack<Card>[] piles = new Stack<Card>[13]; // an array of 13 stacks, each holding Card objects called piles

        public Deck()
        {
            // initializing all piles
            for (int i = 0; i < 13; i++)
            {
                piles[i] = new Stack<Card>();
            }
        }

        // dealing the cards into the piles
        public void DealCards(List<Card> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int pileIndex = i % 13; // assigning 1-13 piles
                piles[pileIndex].Push(cards[i]); // placing the card

                //Console.WriteLine(cards[i]);
            }

            /*for (int i = cards.Count - 1; i >= 0; i--)
            {
                int pileIndex = i % 13;
                piles[pileIndex].Push(cards[i]); // Pushing from last to first
            }*/

            // to print the piles
            for (int i = 0; i < 13; i++)
            {
                Console.Write($"Pile {i + 1}: ");
                foreach (Card card in piles[i].Reverse()) // reversing the cards as they are face down .Reverse()
                {
                    Console.Write($"{card} "); // printing the contents of the pile
                }
                Console.WriteLine(); // moving to the next line only after printing all cards of the pile
            }
        }

        // returning the pile stack at the given index
        public Stack<Card> GetPile(int index)
        {
            return piles[index];
        }
    }
}
