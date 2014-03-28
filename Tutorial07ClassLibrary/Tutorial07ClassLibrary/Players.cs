using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial07ClassLibrary;

namespace Players
{
    public class Players
    {
        public string Name
        {
            get;
            private set;
        }
        public Cards PlayHand
        {
            get;
            private set;
        }
        private Players()
        {
        }

        public Players(string name)
        {
            Name = name;
            PlayHand = new Cards();
        }
        public bool HasWon()
        {
            bool won = true;
            CardSuit match = PlayHand[0].suit;
            for (int i = 1; i < PlayHand.Count; i++)
            {
                won &= PlayHand[i].suit == match;
            }
            return won;
        }
    }
}
