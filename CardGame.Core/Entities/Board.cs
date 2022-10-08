using CardGame.Core.Interfaces;

namespace CardGame.Core.Entities
{
    /// <summary>
    /// Board class
    /// </summary>
    public class Board : IBoard
    {
        /// <summary>
        /// List of players
        /// </summary>
        public List<IPlayer> Players { get; set; }

        /// <summary>
        /// Baord constructor
        /// </summary>
        public Board()
        {
            Players = new List<IPlayer>();
        }
    }
}
