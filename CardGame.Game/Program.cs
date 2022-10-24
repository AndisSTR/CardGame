using CardGame.Game.Configuration;
using CardGame.Game.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CardGame.Game
{
    /// <summary>
    /// Card game program
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = ServiceConfiguration.ConfigureDependencies();

            var gameManager = serviceProvider.GetService<IGameManager>();

            if (gameManager != null)
            {
                gameManager.StartGame();
            }

            serviceProvider.Dispose();
        }
    }
}
