using CardGame.Core.Entities.Enums;
using CardGame.Core.Interfaces;

namespace CardGame.Core.Entities
{
    /// <summary>
    /// Deck class
    /// </summary>
    public class Deck : IDeck
    {
        private readonly ICard _card;

        /// <summary>
        /// List of cards in deck
        /// </summary>
        public List<Card> Cards { get; set; }

        /// <summary>
        /// Deck class constructor
        /// </summary>
        /// <param name="card">card instance</param>
        public Deck(ICard card)
        {
            Cards = new List<Card>();
            _card = card;
        }

        /// <summary>
        /// Generate new deck of cards
        /// </summary>
        public void GenerateDeck()
        {
            var suitLenght = Enum.GetNames(_card.Suit.GetType()).Length;
            var rankLenght = Enum.GetNames(_card.Rank.GetType()).Length;

            Cards = Enumerable.Range(1, suitLenght)
                .SelectMany(s => Enumerable.Range(1, rankLenght)
                .Select(c => new Card()
                {
                    Suit = (Suit)s,
                    Rank = (Rank)c
                }
            )).ToList();
        }

        /// <summary>
        /// Shuffle deck of cards
        /// </summary>
        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();
        }

        /// <summary>
        /// Take first card from deck
        /// </summary>
        /// <returns>card</returns>
        public Card TakeCard()
        {
            var card = Cards.FirstOrDefault()!;
            Cards.Remove(card);

            return card;
        }

        /// <summary>
        /// Take number of cards from deck
        /// </summary>
        /// <param name="numberOfCards">number of cards</param>
        /// <returns>collection of taken cards from deck</returns>
        public IEnumerable<Card> TakeCards(int numberOfCards)
        {
            var cards = Cards.Take(numberOfCards);

            var takeCards = cards as Card[] ?? cards.ToArray();
            Cards.RemoveAll(takeCards.Contains);

            return takeCards;
        }
    }
}
