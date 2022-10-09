using CardGame.Core.Entities.Enums;
using CardGame.Core.Interfaces;

namespace CardGame.Core.Entities
{
    /// <summary>
    /// Card class
    /// </summary>
    public class Card : ICard
    {
        /// <summary>
        /// Card rank
        /// </summary>
        public Rank Rank { get; set; }

        /// <summary>
        /// Card suit
        /// </summary>
        public Suit Suit { get; set; }

        /// <summary>
        /// Card value
        /// </summary>
        public int Value { get; set; }
    }
}
