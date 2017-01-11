using System;
// using Cards if you wanted card to have namespace card

namespace DeckOfCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Card myCard = new Card("Clubs", 6);
            Card myCard2 = new Card("Hearts", 1);
            Console.WriteLine(myCard.val); //when you run it goes to Card string val get function and 'gets' the return value from the get function we wrote!
            Console.WriteLine(myCard2.val);

            Deck myDeck = new Deck();
            Console.WriteLine(myDeck.deal());
            Console.WriteLine(myDeck);
            myDeck.shuffle();
            Console.WriteLine(myDeck);

            Player Liz =  new Player("Liz");
            Liz.Draw(myDeck);
            Console.WriteLine(Liz.hand[0]);

        }
    }
}
