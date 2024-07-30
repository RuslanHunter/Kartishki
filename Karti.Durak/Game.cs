using System;
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
        public List<Player> Players { get; set; }

        /// <summary>
        /// Колода.
        /// </summary>
        public Deck Deck { get; set; }

        public void InitCardDeck()
        {
            Deck = new Deck();
            
        }
    }
}
