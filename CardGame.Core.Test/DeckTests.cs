using CardGame.Core.Entities;
using CardGame.Core.Interfaces;
using Moq;
using Xunit;

namespace CardGame.Core.Test
{
    public class DeckTests
    {
        public const int DeckLength = 52;

        [Fact]
        public void GenerateDeck_AfterGeneration_ShouldReturnCorrectNumberOfCards()
        {
            // Arrange
            var card = new Mock<ICard>();
            var deck = new Deck(card.Object);

            // Act
            deck.GenerateDeck();
            var result = deck.Cards.Count;

            // Assert
            Assert.Equal(DeckLength, result);
        }

        [Fact]
        public void Shuffle_AfterShuffle_ShouldReturnsNotEqual()
        {
            // Arrange
            var card = new Mock<ICard>();
            var deck = new Deck(card.Object);

            // Act
            deck.GenerateDeck();
            var result = deck.Cards;
            deck.Shuffle();
            var shuffle = deck.Cards;

            // Assert
            Assert.NotEqual(shuffle, result);
        }

        [Fact]
        public void TakeCard_AfterCardIsTaken_ShouldReturnCorrectNumberOfCards()
        {
            // Arrange
            var card = new Mock<ICard>();
            var deck = new Deck(card.Object);

            // Act
            deck.GenerateDeck();
            deck.TakeCard();
            var result = deck.Cards.Count;
            var expected = DeckLength - 1;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TakeCards_AfterCardsIsTaken_ShouldReturnCorrectNumberOfCards()
        {
            // Arrange
            int cardsTaken = 8;
            var card = new Mock<ICard>();
            var deck = new Deck(card.Object);

            // Act
            deck.GenerateDeck();
            deck.TakeCards(cardsTaken);
            var result = deck.Cards.Count;
            var expected = DeckLength - cardsTaken;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TakeCard_TakenCardDoesNotAppearInDeck_ShouldReturnFalse()
        {
            // Arrange
            var card = new Mock<ICard>();
            var deck = new Deck(card.Object);

            // Act
            deck.GenerateDeck();
            var takenCard = deck.TakeCard();
            var result = deck.Cards.Any(c => c.Suit == takenCard.Suit && c.Rank == takenCard.Rank);

            // Assert
            Assert.False(result);
        }
    }
}