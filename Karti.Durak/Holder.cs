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
            Ranks = new List<CardRank>();
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
