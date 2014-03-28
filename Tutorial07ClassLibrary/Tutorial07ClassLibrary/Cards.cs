using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial07ClassLibrary
{
    public class Cards
    {
        public readonly CardRank rank;
        public readonly CardSuit suit;

        public Cards(CardSuit newSuit, CardRank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        private Cards()
        {
        }

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}
