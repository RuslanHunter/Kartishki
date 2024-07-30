using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    /// <summary>
    /// Игральная карта.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Старшинство.
        /// </summary>
        public CardRank Rank { get; set; }

        /// <summary>
        /// Масть.
        /// </summary>
        public CardSuit Suit { get; set; }
    }
}
