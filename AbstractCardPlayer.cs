using System;
using System.Collections.Generic;

namespace Card
{
    abstract class AbstractCardPlayer : ICardPlayer
    {
        protected List<Card> hand;
        protected IGame game;

        public AbstractCardPlayer(IGame game)
        {
            if (game == null)
            {
                throw new Exception();
            }

            this.game = game;
            this.hand = new List<Card>();
        }

        public void receive(Card card)
        {
            this.hand.Add(card);
        }

        abstract public Card play();
        abstract public Card swap(Card card);
    }
}
