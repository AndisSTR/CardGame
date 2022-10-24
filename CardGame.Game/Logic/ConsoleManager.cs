using CardGame.Game.Extentions;

namespace CardGame.Game.Logic
{
    /// <summary>
    /// Console Manager
    /// </summary>
    public class ConsoleManager : ConsoleManagerBase
    {
        /// <summary>
        /// Conole cursor visibility
        /// </summary>
        public override bool CursorVisible { get; set; }

        /// <summary>
        /// Clear console
        /// </summary>
        public override void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Reads integer from console input
        /// </summary>
        /// <returns>integer</returns>
        public override int ReadInt()
        {
            return ConsoleExtensions.ReadInt();
        }

        /// <summary>
        /// Console read input key
        /// </summary>
        /// <returns>key info</returns>
        public override ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        /// <summary>
        /// Console read line
        /// </summary>
        /// <returns>string</returns>
        public override string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Console write
        /// </summary>
        /// <param name="value">string</param>
        public override void Write(string value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Console write line
        /// </summary>
        /// <param name="value">string</param>
        public override void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Sets cursor position
        /// </summary>
        /// <param name="left">left coord</param>
        /// <param name="top">top coord</param>
        public override void SetCursorPosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }
    }
}
