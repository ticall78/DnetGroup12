// Card Rank Enumeration used

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeterCardLibrary // Name of the enum
{
    public enum Rank : byte
    {  // Rank types, with the underlying value for Ace of 1
        Ace = 1,
        Deuce,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Joker
    }
}
