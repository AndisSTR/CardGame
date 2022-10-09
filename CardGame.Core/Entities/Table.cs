using CardGame.Core.Interfaces;

namespace CardGame.Core.Entities
{
    /// <summary>
    /// Table class
    /// </summary>
    public class Table : ITable
    {
        /// <summary>
        /// List of players
        /// </summary>
        public List<IPlayer> Players { get; set; }

        /// <summary>
        /// Table constructor
        /// </summary>
        public Table()
        {
            Players = new List<IPlayer>();
        }
    }
}
