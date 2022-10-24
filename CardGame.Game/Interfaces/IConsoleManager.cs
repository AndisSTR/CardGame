namespace CardGame.Game.Interfaces
{
    /// <summary>
    /// Console Manager Interface
    /// </summary>
    public interface IConsoleManager
    {
        /// <summary>
        /// Console write
        /// </summary>
        /// <param name="value">string</param>
        void Write(string value);

        /// <summary>
        /// Reads integer from console input
        /// </summary>
        /// <returns>integer</returns>
        int ReadInt();

        /// <summary>
        /// Console write line
        /// </summary>
        /// <param name="value">string</param>
        void WriteLine(string value);

        /// <summary>
        /// Console read input key
        /// </summary>
        /// <returns>key info</returns>
        ConsoleKeyInfo ReadKey();

        /// <summary>
        /// Console read line
        /// </summary>
        /// <returns>string</returns>
        string ReadLine();

        /// <summary>
        /// Clear console
        /// </summary>
        void Clear();

        /// <summary>
        /// Conole cursor visibility
        /// </summary>
        bool CursorVisible { get; set; }

        /// <summary>
        /// Sets cursor position
        /// </summary>
        /// <param name="left">left coord</param>
        /// <param name="top">top coord</param>
        void SetCursorPosition(int left, int top);
    }
}
