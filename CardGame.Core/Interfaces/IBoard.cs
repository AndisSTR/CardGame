namespace CardGame.Core.Interfaces
{
    public interface IBoard
    {
        /// <summary>
        /// List of players
        /// </summary>
        List<IPlayer> Players { get; set; }
    }
}
