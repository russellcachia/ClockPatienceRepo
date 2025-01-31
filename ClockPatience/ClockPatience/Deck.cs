using System;
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

        // dealing the cards to the piles
        public void DealCards(List<Card> cards)
        {
            int pileIndex = 0;

            foreach (Card card in cards)
            {
                piles[pileIndex].Push(card);
                pileIndex = (pileIndex + 1) % 13; // div by 13 instead of piles.length to rotate through the piles
            }
        }

        // returning the pile stack at the given index
        public Stack<Card> GetPile(int index)
        {
            return piles[index];
        }
    }
}
