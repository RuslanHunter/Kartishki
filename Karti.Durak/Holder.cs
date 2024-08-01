using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    public class Holder
    {
        public Card[] Cards { get; set; }
        public List<CardRank> Ranks { get; set; }
        public List<CardSuit> Suits{ get; set; }
        public Holder()
        {
            Ranks =
                [
                new CardRank(6, "6"),
                new CardRank(7, "7"),
                new CardRank(8, "8"),
                new CardRank(9, "9"),
                new CardRank(10, "10"),
                new CardRank(11, "Jack"),
                new CardRank(12, "Queen"),
                new CardRank(13, "King"),
                new CardRank(14, "Ace")
                ];

            Suits =
                [
                    new CardSuit 
                ];

            for (var i = 6; i <= 10; i++)
            {
                for (var i2 = 6; i2 <= 10; i2++)
                {
                    var card = new Card();
                    card.Rank = new CardRank();
                }
            }
        }
    }
}
