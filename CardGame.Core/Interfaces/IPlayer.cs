namespace CardGame.Core.Interfaces
{
    /// <summary>
    /// Player class interface
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Player hand
        /// </summary>
        IHand Hand { get; set; }

        /// <summary>
        /// Player score
        /// </summary>
        int Score { get; set; }

        /// <summary>
        /// Player is dealers
        /// </summary>
        bool IsDealer { get; set; }
    }
}
