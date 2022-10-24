using CardGame.Core.Entities;
using CardGame.Core.Interfaces;
using Moq;
using Xunit;

namespace CardGame.Core.Test
{
    public class HandTests
    {
        [Fact]
        public void AddCard_AfterCardIsAdded_HandShouldReturn_CorrectNumberOfCards()
        {
            // Arrange
            var card = new Mock<ICard>();
            var deck = new Deck(card.Object);
            var hand = new Hand(deck);

            // Act
            deck.GenerateDeck();
            hand.AddCard();
            var result = hand.Cards.Count;

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void AddCards_AfterCardsIsAdded_HandShouldReturn_CorrectNumberOfCards()
        {
            // Arrange
            int cardsToAdd = 8;
            var card = new Mock<ICard>();
            var deck = new Deck(card.Object);
            var hand = new Hand(deck);

            // Act
            deck.GenerateDeck();
            hand.AddCards(cardsToAdd);
            var result = hand.Cards.Count;

            // Assert
            Assert.Equal(cardsToAdd, result);
        }
    }
}
