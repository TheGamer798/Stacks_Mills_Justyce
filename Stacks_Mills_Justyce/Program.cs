namespace Stacks_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Card[] myCardsArray = new Card[]//Card array with Card objects with appropriate values
            {
                new Card("Ace", "Clubs"),
                new Card("4", "Diamonds"),
                new Card("Jack", "Spades"),
                new Card("3", "Hearts"),
                new Card("Ace", "Diamonds"),
                new Card("King", "Clubs"),
                new Card("9", "Hearts"),
                new Card("10", "Spades"),
                new Card("2", "Diamonds")
            };

            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);//Card stack and push the cards to it

            Console.WriteLine("Cards in Deck:");//Print to console, "Cards in the deck:"
            foreach (Card card in myCardsArray)//Loop through the stack and print on a new line for each card, "The <Number> of <Suit>"
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}");
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");//Print to console the number of cards in the stack

            List<Card> myHand = new List<Card>();// new Card list
            myHand.Add(new Card("6", "Hearts"));
            myHand.Add(new Card("Queen", "Clubs"));
            myHand.Add(new Card("8", "Spades"));

            Console.WriteLine("Got any 8's?");//Print to console, "Got any 8's?"
            if (startingDeck.Count > 0)//If possible, add a card to myHand from the stack by popping it
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");//Print to console the number of cards in the stack

            startingDeck.Push(myHand[0]);//Place one of the cards in your hand
            myHand.RemoveAt(0);//Delete the card you placed from your hand

            Console.WriteLine("Cards in Deck:");//Print to console, "Cards in the deck:"
            foreach (Card card in myCardsArray)//Loop through the stack and print on a new line for each card, "The <Number> of <Suit>!"
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}");
            }

        }
    }
}