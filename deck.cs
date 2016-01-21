using System;
using System.Collections.Generic;
using System.Linq;

namespace Card
{
    class Deck
    {
        private List<Card> deck;

        public Deck()
        {
            this.deck = new List<Card>(54);

            foreach( Card.Rank rank in Enum.GetValues(typeof(Card.Rank)) )
            {
                foreach( Card.Suit suit in Enum.GetValues(typeof(Card.Suit)) )
                {
                    Card.Suit[] jokerSuits = {Card.Suit.BLACK, Card.Suit.RED};

                    // if it's the joker rank or a joker suit
                    if( rank == Card.Rank.JOKER || jokerSuits.Contains(suit) )
                    {
                        // if it's the joker and a joker suit
                        if (rank == Card.Rank.JOKER && jokerSuits.Contains(suit))
                        {
                            this.deck.Add(new Card(suit, rank));
                        }
                    }
                    else
                    {
                        this.deck.Add(new Card(suit, rank));
                    }
                }
            }
        }

        public void cut()
        {
        }

        public Card draw()
        {
            // get the top card
            Card drawn = this.deck[0];
            // remove it from the deck
            this.deck.RemoveAt(0);

            return drawn;
        }

        public Card peek()
        {
            return this.deck[0];
        }

        public void shuffle()
        {
            // TODO: find a reasonable shuffling algorithm
        }
    }
}