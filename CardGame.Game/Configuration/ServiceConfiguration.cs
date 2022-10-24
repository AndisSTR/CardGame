using CardGame.Core.Entities;
using CardGame.Core.Interfaces;
using CardGame.Game.Interfaces;
using CardGame.Game.Logic;
using Microsoft.Extensions.DependencyInjection;

namespace CardGame.Game.Configuration
{
    /// <summary>
    /// Service configuration
    /// </summary>
    public static class ServiceConfiguration
    {
        /// <summary>
        /// Service configuration for dependency injections
        /// </summary>
        /// <returns>Service provider with configured dependency injections</returns>
        public static ServiceProvider ConfigureDependencies()
        {
            return new ServiceCollection()
                .AddScoped<ITable, Table>()
                .AddScoped<IDeck, Deck>()
                .AddScoped<ICard, Card>()
                .AddScoped<IGameManager, GameManager>()
                .AddScoped<IConsoleManager, ConsoleManager>()
                .BuildServiceProvider();
        }
    }
}
