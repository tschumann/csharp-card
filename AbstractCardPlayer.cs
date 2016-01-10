using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card
{
    abstract class AbstractCardPlayer : ICardPlayer
    {
        private List<Card> hand;

        public AbstractCardPlayer()
        {
            this.hand = new List<Card>();
        }

        abstract public Card play();

        public void receive(Card card)
        {
            this.hand.Add(card);
        }
    }
}
