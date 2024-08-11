using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    public static class CardsHolder
    {
        private static List<Card>? _cards;

        public static List<Card> GetCards()
        {
            if (_cards == null)
            {
                _cards = InitCards();
            }
            return _cards;
        }

        private static List<Card> InitCards()
        {
            var ranks = new List<CardRank>()
            {
                new CardRank(6, "6"),
                new CardRank(7, "7"),
                new CardRank(8, "8"),
                new CardRank(9, "9"),
                new CardRank(10, "10"),
                new CardRank(11, "Jack"),
                new CardRank(12, "Queen"),
                new CardRank(13, "King"),
                new CardRank(14, "Ace")
            };

            var suits = new List<CardSuit>()
            {
                new CardSuit(0, "Clubs", '♣'),
                new CardSuit(0, "Hearts", '♥'),
                new CardSuit(0, "Diamonds", '♦'),
                new CardSuit(0, "Spades", '♠')
            };

            var cards = new List<Card>();
            foreach (var rank in ranks)
            {
                foreach (var suit in suits)
                {
                    var card = new Card(rank, suit);
                    cards.Add(card);
                }
            }
            return cards;
        }
    }
}
