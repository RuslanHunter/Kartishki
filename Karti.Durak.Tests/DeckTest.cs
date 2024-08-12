namespace Karti.Durak.Tests
{
    public class DeckTest
    {
        [Test]
        public void DeckCardsCountTest()
        {
            var game = new Game();
            game.InitCardDeck();
            Assert.That(game.Deck?.Cards.Count, Is.EqualTo(36));
            Assert.That(game.Deck?.Cards.GroupBy(x => x.Rank.Value).Count(), Is.EqualTo(9));
            Assert.That(game.Deck?.Cards.GroupBy(x => x.Suit.Value).Count(), Is.EqualTo(4));
        }
    }
}