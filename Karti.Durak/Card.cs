﻿using System;
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
        /// Игральная карта.
        /// </summary>
        /// <param name="rank"><see cref="Rank"></param>
        /// <param name="suit"><see cref="Suit"></param>
        public Card(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }
        /// <summary>
        /// Старшинство.
        /// </summary>
        public CardRank Rank { get; }

        /// <summary>
        /// Масть.
        /// </summary>
        public CardSuit Suit { get; }
    }
}
