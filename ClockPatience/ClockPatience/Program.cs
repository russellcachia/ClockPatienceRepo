namespace ClockPatience
{
    class Program //interal
    {
        static void Main(string[] args)
        {
            List<string> inputDecks = new List<string>();
            string line;

            // reading the input
            while ((line = Console.ReadLine()) != "#")
            {
                inputDecks.Add(line);
            }

            // processing the deck
            foreach (var deckInput in inputDecks)
            {
                List<Card> cards = new List<Card>();
                string[] cardStrings = deckInput.Split(' ');

                foreach (var cardString in cardStrings)
                {
                    string rank = cardString.Substring(0, 1);
                    string suit = cardString.Substring(1, 1);
                    cards.Add(new Card(rank, suit));
                }

                // creating and dealing the cards
                Deck deck = new Deck();
                deck.DealCards(cards);

                // play the game and get result
                var result
            }
        }
    }
}
