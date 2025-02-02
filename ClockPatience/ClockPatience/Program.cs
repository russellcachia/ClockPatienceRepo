namespace ClockPatience
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputDecks = new List<string>();

            // reading the inputa
            while (true)
            {
                string line1 = Console.ReadLine();
                if (line1 == "#") break; // checking if a "#" is present

                string line2 = Console.ReadLine();
                if (line2 == "#") break; // checking if a "#" is present

                string line3 = Console.ReadLine();
                if (line3 == "#") break; // checking if a "#" is present

                string line4 = Console.ReadLine();
                if (line4 == "#") break; // checking if a "#" is present

                string fullDeck = $"{line1} {line2} {line3} {line4}"; // combining all 4 lines together
                inputDecks.Add(fullDeck);
            }

            // processing the deck
            foreach (var deckInput in inputDecks)
            {
                List<Card> cards = new List<Card>();
                string[] cardStrings = deckInput.Split(' ');

                foreach (var cardString in cardStrings)
                {
                    string rank = cardString.Substring(0, 1); // extracting the rank of the card
                    string suit = cardString.Substring(1, 1); // extracting the suit of the card
                    cards.Add(new Card(rank, suit)); // creating a new Card object with the extracted rank and suit
                }

                // creating and dealing the cards
                Deck deck = new Deck();
                deck.DealCards(cards);

                // play the game and get result
                var result = PlayGame(deck);

                // output result
                Console.WriteLine($"Result: {result}");
            }
        }

        // game logic
        static (int exposedCards, string lastCardExposed) PlayGame(Deck deck)
        {
            int exposedCards = 0;
            Card currentCard = deck.GetPile(12).Pop(); // starting with the king pile
            //Console.WriteLine($"Starting card: {currentCard.GetPileIndex()}");

            while (true)
            {
                exposedCards++;
                //Console.WriteLine($"Exposing card {currentCard} from pile {currentCard.GetPileIndex()}");

                int pileIndex = currentCard.GetPileIndex() - 1; // determines the next pile to move to

                // i fno more cards in current pile
                if (deck.GetPile(pileIndex).Count == 0)
                {
                    break;
                }

                currentCard = deck.GetPile(pileIndex).Pop(); // move to the next pile, .Pop() removes and returns the topmost element in a stack
                Console.WriteLine($"Moving to pile {pileIndex + 1} and exposing card {currentCard}");
            }

            return (exposedCards, currentCard.ToString());
        }
    }
}
