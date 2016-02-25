using System;
using System.Collections.Generic;

namespace Card
{
    class Deck
    {
        private List<Card> deck;
        private IGame game;

        public Deck(IGame game, bool hasJokers)
        {
            if (game == null)
            {
                throw new Exception();
            }

            this.game = game;
            this.deck = new List<Card>(hasJokers ? 54 : 52);

            foreach( Card.Rank rank in Enum.GetValues(typeof(Card.Rank)) )
            {
                foreach( Card.Suit suit in Enum.GetValues(typeof(Card.Suit)) )
                {
                    // TODO: why can't I use the array literal in the List constructor?
                    Card.Suit[] suits = { Card.Suit.BLACK, Card.Suit.RED };
                    List<Card.Suit> jokerSuits = new List<Card.Suit>(suits);

                    // if it's the joker rank or a joker suit
                    if (rank == Card.Rank.JOKER || jokerSuits.Contains(suit))
                    {
                        // if we want to add jokers and if it's the joker and a joker suit
                        if (hasJokers && rank == Card.Rank.JOKER && jokerSuits.Contains(suit))
                        {
                            this.deck.Add(new Card(suit, rank, this.game));
                        }
                    }
                    else
                    {
                        this.deck.Add(new Card(suit, rank, this.game));
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