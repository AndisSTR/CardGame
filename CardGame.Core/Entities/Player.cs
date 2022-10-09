using CardGame.Core.Interfaces;

namespace CardGame.Core.Entities
{
    /// <summary>
    /// Player class
    /// </summary>
    public class Player : IPlayer
    {
        private readonly IDeck _deck;

        /// <summary>
        /// Player hand
        /// </summary>
        public IHand Hand { get; set; }

        /// <summary>
        /// Player score
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Player is dealers
        /// </summary>
        public bool IsDealer { get; set; }

        /// <summary>
        /// Player class constructor
        /// </summary>
        /// <param name="deck">IDeck instace</param>
        public Player(IDeck deck)
        {
            _deck = deck;
            Hand = new Hand(_deck);
            IsDealer = false;
        }
    }
}
