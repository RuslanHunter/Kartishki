using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    /// <summary>
    /// Игральная крата на столе.
    /// </summary>
    public class TableCard
    {
        public TableCard(Game game, Card attackCard)
        {
            AttackCard = attackCard;
            Game = game;
        }

        /// <summary>
        /// Атакующая карта.
        /// </summary>
        public Card AttackCard { get; }

        /// <summary>
        /// Защищающаяся карта.
        /// </summary>
        public Card? DefenceCard { get; private set; }

        /// <summary>
        /// Игра.
        /// </summary>
        public Game Game { get; }

        /// <summary>
        /// Защититься
        /// </summary>
        /// <param name="card"></param>
        public void Defence(Card defenceCard)
        {
            if(defenceCard.Suit == Game.Deck.TrumpCard.Suit)
            {
                if(AttackCard.Suit == Game.Deck.TrumpCard.Suit)
                {
                    if(defenceCard.Rank.Value > AttackCard.Rank.Value)
                    {
                        DefenceCard = defenceCard;
                    }
                    else
                    {
                        throw new Exception("defence card rank small");
                    }
                }
                else 
                {
                    DefenceCard = defenceCard;
                }
            }
            else
            {
                if (defenceCard.Suit == Game.Deck.TrumpCard.Suit)
                {
                    if (defenceCard.Rank.Value > AttackCard.Rank.Value)
                    {
                        DefenceCard = defenceCard;
                    }
                    else
                    {
                        throw new Exception("defence card rank small");
                    }
                }
                else
                {
                    throw new Exception("defence suit invalid");
                }
            }
        }
    }
}
