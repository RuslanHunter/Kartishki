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
            Deck = new Deck();
        }

        /// <summary>
        /// Игроки.
        /// </summary>
        public IEnumerable<Player> Players => _players;

        /// <summary>
        /// Колода.
        /// </summary>
        public Deck Deck { get; private set; }

        /// <summary>
        /// Индекс игрока, который сейчас ходит.
        /// </summary>
        private int? _activePlayerIndex;

        /// <summary>
        /// Индекс игрока, который сейчас ходит.
        /// </summary>
        public Player? ActivePlayer
        {
            get
            {
               if (_activePlayerIndex == null)
                {
                    return null;
                }
                else
                {
                    return (Player?)_players[_activePlayerIndex.Value];
                }
            }
        }
        
    

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
            _activePlayerIndex = null;
            var isSuccess = false;
            while (!isSuccess)
            {
                var result = GoGo();
                //Козырей нету, перетусуем колоду.
            }
        }

        private bool GoGo()
        {
            foreach (var player in _players)
            {
                player.Hand.Clear();
            }

            
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

            var trumpSuitValue = Deck.TrumpCard.Suit.Value;
            var minHandTrumpSuits = new Dictionary<int, Player>();
            foreach (var player in _players)
            {
                var minTrumpRank = player.Hand.Cards
                    .Where(x => x.Suit.Value == trumpSuitValue)
                    .OrderBy(x => x.Rank.Value)
                    .FirstOrDefault()?.Rank.Value;
                if (minTrumpRank != null)
                {
                    minHandTrumpSuits.Add(minTrumpRank.Value, player);
                }
            }
            var minTrumpSuitPlayer = minHandTrumpSuits.OrderBy(x => x.Key).FirstOrDefault().Value;
            if (minTrumpSuitPlayer != null)
            {
                var ActivePlayerIndex = _players.IndexOf(minTrumpSuitPlayer);
                return true;
            }
            return false;
        }
    }
}
