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
            _cards = new List<Card>();
        }

        /// <summary>
        /// Карты.
        /// </summary>
        private List<Card> _cards { get; set; }


        /// <summary>
        /// Количество карт в колоде.
        /// </summary>
        public int CardsCount => _cards.Count;

        /// <summary>
        /// Перетусовать колоду.
        /// </summary>
        /// <remarks>
        /// Создать колоду с картами расположенными в случайном порядке.
        /// </remarks>
        public void Shuffle()
        {
            _cards = CardsHolder.GetCards()
                .Select(x => new { Order = Globals.Random.Next(), Card = x })
                .OrderBy(x => x.Order)
                .Select(x => x.Card).ToList();
        }

        /// <summary>
        /// Достать карту из колоды.
        /// </summary>
        /// <returns></returns>
        public Card PullCard()
        {
            var card = _cards.LastOrDefault();
            if (card == null)
            {
                throw new Exception("deck empty");
            }
            _cards.Remove(card);
            return card;
        }
    }
}
