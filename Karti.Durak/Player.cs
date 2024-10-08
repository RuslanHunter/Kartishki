﻿namespace Karti.Durak
{
    /// <summary>
    /// Игрок.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Игрок.
        /// </summary>
        public Player()
        {
            Hand = new PlayerHand();
        }

        /// <summary>
        /// Имя игрока.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Рука.
        /// </summary>
        public PlayerHand Hand { get; set; }
    }
    /// <summary>
    /// Рука игрока с картами.
    /// </summary>
    public class PlayerHand
    {
        /// <summary>
        /// Рука игрока с картами.
        /// </summary>
        public PlayerHand()
        {
            _cards = new List<Card>();
        }

        /// <summary>
        /// Карты в руке.
        /// </summary>
        public IEnumerable<Card> Cards => _cards;
        private List<Card> _cards;

        /// <summary>
        /// Взять карту в руку.
        /// </summary>
        /// <param name="card"></param>
        public void TakeCard(Card card)
        {
            _cards.Add(card);
        }

        /// <summary>
        /// Сходить
        /// </summary>
        /// <param name="card"></param>
        public void PlayCard(Card card)
        {
            if (_cards.Contains(card))
            {
                _cards.Remove(card);
            }
            else 
            {
                throw new Exception("undefined card");
            }
        }


        /// <summary>
        /// Отчистить руку от карт.
        /// </summary>
        public void Clear()
        { 
            _cards = new List<Card>();
        }

        /// <summary>
        /// Получить карту с минимальным значение козыря
        /// </summary>
        /// <param name="suit"></param>
        /// <returns></returns>
        public Card? GetMinSuitCard(CardSuit suit)
        {
            return Cards
               .Where(x => x.Suit.Value == suit.Value)
               .OrderBy(x => x.Rank.Value)
               .FirstOrDefault();
        }
    }
}
