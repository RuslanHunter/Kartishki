using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    /// <summary>
    /// Колодка карт.
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// Инициализация колоды.
        /// </summary>
        public Deck()
        {
            Cards = new List<Card>();
        }
        public List<Card> Cards { get; set; }
    }
}
