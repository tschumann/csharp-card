using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card
{
    abstract class AbstractCardPlayer : ICardPlayer
    {
        protected List<Card> hand;

        public AbstractCardPlayer()
        {
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
