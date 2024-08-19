namespace Karti.Durak.Tests
{
    public class DeckTest
    {
        /// <summary>
        /// ������������ ������ � ��������� ��� � ��� 9 ��������� ���� � 4 �����, � ���� 36 ����.
        /// </summary>
        [Test]
        public void DeckCardsCountTest()
        {
            var deck = new Deck();
            deck.Shuffle();
            var cards = new List<Card>();
            while(deck.CardsCount > 0)
            {
                var card = deck.PullCard();
                cards.Add(card);
            }
            Assert.That(cards.Count, Is.EqualTo(36));
            Assert.That(cards.GroupBy(x => x.Rank.Value).Count(), Is.EqualTo(9));
            Assert.That(cards.GroupBy(x => x.Suit.Value).Count(), Is.EqualTo(4));
        }


        /// <summary>
        /// ������� ������� �� 6 ���� � ������ ����.
        /// </summary>
        /// <param name="playerCount">���������� �������.</param>
        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        public void TwoPlayersStartGameTest(int playerCount)
        {
            var game = new Game();
            for (var  i = 0; i < playerCount; i++)
            {
                game.AddPlayer(new Player());
            }
            game.InitCardDeck();

            foreach (var player in game.Players)
            {
                Assert.That(game.Players.First().Hand.Cards.Count(), Is.EqualTo(6));
            }
        }
    }
}