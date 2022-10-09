namespace CardGame.Core.Interfaces
{
    /// <summary>
    /// Table class interface
    /// </summary>
    public interface ITable
    {
        /// <summary>
        /// List of players
        /// </summary>
        List<IPlayer> Players { get; set; }
    }
}
