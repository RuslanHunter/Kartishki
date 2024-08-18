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
        private List<Player> _players;

        /// <summary>
        /// Игра.
        /// </summary>
        public Game()
        {
            _players = new List<Player>();
        }

        /// <summary>
        /// Игроки.
        /// </summary>
        public IEnumerable<Player> Players => _players;

        /// <summary>
        /// Колода.
        /// </summary>
        public Deck? Deck { get; private set; }

        /// <summary>
        /// Добавить игрока в игру.
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(Player player)
        {
            if (_players.Count > 6)
            {
                throw new Exception("max player count = 6");
            }
            _players.Add(player);
        }

        public void InitCardDeck()
        {
            Deck = new Deck();
            Deck.Shuffle();

            if (_players.Count < 2)
            {
                throw new Exception("need two or more players");
            }

            if (_players.Count > 6)
            {
                throw new Exception("need six players");
            }

            for (int i = 0; i < 6; i++)
            {
                foreach (var player in _players)
                {
                    var card = Deck.PullCard();
                    player.Hand.TakeCard(card);
                }
            }
        }
    }
}
