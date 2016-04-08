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
            Deck d = new Deck();

            d.shuffle();

            for (int i = 0; i < d.getCards().Length; i++)
            {
                Card c = d.getCards()[i];
                Console.WriteLine(c.getFaceValue() + " " + c.getSuit());
            }
        }
    }
}
