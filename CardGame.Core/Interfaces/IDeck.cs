using CardGame.Core.Entities;

namespace CardGame.Core.Interfaces
{
    /// <summary>
    /// Deck class interface
    /// </summary>
    public interface IDeck
    {
        /// <summary>
        /// List of cards in deck
        /// </summary>
        List<Card> Cards { get; set; }

        /// <summary>
        /// Generate new deck of cards
        /// </summary>
        void GenerateDeck();

        /// <summary>
        /// Shuffle deck of cards
        /// </summary>
        void Shuffle();

        /// <summary>
        /// Take first card from deck
        /// </summary>
        /// <returns>card</returns>
        Card? TakeCard();

        /// <summary>
        /// Take number of cards from deck
        /// </summary>
        /// <param name="numberOfCards">number of cards</param>
        /// <returns>collection of taken cards from deck</returns>
        IEnumerable<Card> TakeCards(int numberOfCards);
    }
}
