using CardGame.Game.Interfaces;
using CardGame.Core.Interfaces;
using CardGame.Core.Entities;
using static System.Console;

namespace CardGame.Game.Logic
{
    public class GameManager : IGameManager
    {
        private readonly ITable _table;
        private readonly IDeck _deck;
        private readonly IConsoleManager _consoleManager;

        public GameManager(ITable table, IDeck deck, IConsoleManager consoleManager)
        {
            _table = table;
            _deck = deck;
            _consoleManager = consoleManager;
        }

        public void StartGame()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            _consoleManager.Clear();
            SetupTablePlayers(3);
            _deck.GenerateDeck();
            _deck.Shuffle();
            DealPlayerCards(8);
            DisplayGame();
        }

        private void SetupTablePlayers(int count)
        {
            for(int i = 0; i < count; i++)
            {
                var player = new Player(_deck);
                _table.Players.Add(player);
            }
        }

        private void DealPlayerCards(int amount)
        {
            foreach (var player in _table.Players)
            {
                player.Hand.AddCards(amount);
            }
        }

        private void DisplayGame()
        {
            int index = 0;
            foreach (var player in _table.Players)
            {
                index++;
                _consoleManager.WriteLine("\nPlayer" + index+":\n");
                foreach (var card in player.Hand.Cards)
                {
                    _consoleManager.WriteLine(card.ToString());
                }
            }
        }
    }
}
