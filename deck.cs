using System;
using System.Collections.Generic;

namespace Card
{
    class Deck
    {
        private List<Card> deck;

        public Deck()
        {
            this.deck = new List<Card>(54);

            foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
            {
                foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
                {
                    // TODO: deal with jokers
                    this.deck.Add(new Card(suit, rank));
                }
            }
        }

        public void shuffle()
        {
        }
    }
}