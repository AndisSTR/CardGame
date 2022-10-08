using CardGame.Core.Entities.Enums;

namespace CardGame.Core.Interfaces
{
    /// <summary>
    /// Card class interface
    /// </summary>
    public interface ICard
    {
        /// <summary>
        /// Card rank
        /// </summary>
        Rank Rank { get; set; }

        /// <summary>
        /// Card suit
        /// </summary>
        Suit Suit { get; set; }
    }
}
