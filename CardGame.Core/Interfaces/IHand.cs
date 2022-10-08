using CardGame.Core.Entities;

namespace CardGame.Core.Interfaces
{
    /// <summary>
    /// Hand class interface
    /// </summary>
    public interface IHand
    {
        /// <summary>
        /// List of cards in hand
        /// </summary>
        List<Card> Cards { get; set; }

        /// <summary>
        /// Add card to hand
        /// </summary>
        void AddCard();

        /// <summary>
        /// Add number of cards to hand
        /// </summary>
        /// <param name="numberOfCards">number of cards</param>
        void AddCards(int numberOfCards);
    }
}
