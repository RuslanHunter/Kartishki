﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    /// <summary>
    /// Игра.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Игроки.
        /// </summary>
        public List<Player>? Players { get; set; }

        /// <summary>
        /// Колода.
        /// </summary>
        public Deck? Deck { get; private set; }

        public void InitCardDeck()
        {
            Deck = new Deck();
            Deck.Cards = CardsHolder.GetCards()
                .Select(x => new { Order = Globals.Random.Next(), Card = x })
                .OrderBy(x => x.Order)
                .Select(x => x.Card).ToList();
        }
    }
}
