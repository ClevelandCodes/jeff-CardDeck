using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a New Deck with the Cards filled
            Deck d = new Deck();

            // Shuffle the Deck
            d.shuffle();

            // Print out the Shuffled Deck, one card at a time.
            for (int i = 0; i < d.getCards().Length; i++)
            {
                Card c = d.getCards()[i];
                Console.WriteLine(c.getFaceValue() + " " + c.getSuit());
            }

            // Now to Get a Hand
            Console.WriteLine("");
            Console.WriteLine("Get a Random Hand:");

            // call getHand and store it in the newHand variable
            Card[] newHand = d.getHand();
            for (int i = 0; i < newHand.Length; i++)
            {
                Card c = newHand[i];
                Console.WriteLine(c.getFaceValue() + " " + c.getSuit());
            }
        }
    }
}
