using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    class Deck
    {
        private Card[] CardList;

        public Deck()
        {
            string[] Suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            CardList = new Card[52];
            for (int i = 0; i < Suits.Length; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    CardList[i * 13 + j] = new Card(Suits[i], j + 1);
                }
            }
        }

        public void shuffle()
        {
            int nextIndex = 0;
            Random rnd = new Random();
            Card[] shuffledDeck = new Card[52];
            while (nextIndex < 52)
            {
                int randomNumber = rnd.Next(52);
                if (CardList[randomNumber] != null)
                {
                    shuffledDeck[nextIndex] = CardList[randomNumber];
                    CardList[randomNumber] = null;
                    nextIndex++;
                }
            }

            CardList = shuffledDeck;
        }

        public Card[] getCards()
        {
            return CardList;
        }

        public Card[] getHand()
        {
            // First Shuffle the deck so it's random
            shuffle();

            // Next get the first 5 cards
            Card[] hand = new Card[5];
            for (int i = 0; i < hand.Length; i++)
            {
                hand[i] = CardList[i];
            }

            //Return the hand I created
            return hand;
        }
    }
}
