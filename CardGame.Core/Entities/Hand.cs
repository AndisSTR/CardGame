using CardGame.Core.Interfaces;

namespace CardGame.Core.Entities
{
    /// <summary>
    /// Hand class
    /// </summary>
    public class Hand : IHand
    {
        private readonly IDeck _deck;

        /// <summary>
        /// List of cards in hand
        /// </summary>
        public List<Card> Cards { get; set; }

        /// <summary>
        /// Hand class constructor
        /// </summary>
        /// <param name="deck">IDeck instance</param>
        public Hand(IDeck deck)
        {
            Cards = new List<Card>();
            _deck = deck;
        }

        /// <summary>
        /// Add card to hand
        /// </summary>
        public void AddCard()
        {
            var card = _deck.TakeCard();

            if (card != null)
            {
                Cards.Add(card);
            }
        }

        /// <summary>
        /// Add number of cards to hand
        /// </summary>
        /// <param name="numberOfCards">number of cards</param>
        public void AddCards(int numberOfCards)
        {
            var cards = _deck.TakeCards(numberOfCards);
            Cards.AddRange(cards);
        }
    }
}
