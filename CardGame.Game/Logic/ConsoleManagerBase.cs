using CardGame.Game.Interfaces;

namespace CardGame.Game.Logic
{
    /// <summary>
    /// Console Manager Base
    /// </summary>
    public abstract class ConsoleManagerBase : IConsoleManager
    {
        /// <summary>
        /// Conole cursor visibility
        /// </summary>
        public abstract bool CursorVisible { get; set; }

        /// <summary>
        /// Reads integer from console input
        /// </summary>
        /// <returns>integer</returns>
        public abstract int ReadInt();

        /// <summary>
        /// Sets cursor position
        /// </summary>
        /// <param name="left">left coord</param>
        /// <param name="top">top coord</param>
        public abstract void SetCursorPosition(int left, int top);

        /// <summary>
        /// Clear console
        /// </summary>
        public abstract void Clear();

        /// <summary>
        /// Console read input key
        /// </summary>
        /// <returns>key info</returns>
        public abstract ConsoleKeyInfo ReadKey();

        /// <summary>
        /// Console read line
        /// </summary>
        /// <returns>string</returns>
        public abstract string ReadLine();

        /// <summary>
        /// Console write
        /// </summary>
        /// <param name="value">string</param>
        public abstract void Write(string value);

        /// <summary>
        /// Console write line
        /// </summary>
        /// <param name="value">string</param>
        public abstract void WriteLine(string value);
    }
}
