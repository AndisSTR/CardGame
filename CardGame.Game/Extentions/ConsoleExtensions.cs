namespace CardGame.Game.Extentions
{
    /// <summary>
    /// Console Extensions
    /// </summary>
    public class ConsoleExtensions
    {
        /// <summary>
        /// Extension method for reading console values as integer
        /// </summary>
        /// <returns>integer</returns>
        public static int ReadInt()
        {
            string inputString = Console.ReadLine();
            int intValue;

            if (int.TryParse(inputString, out intValue))
            {
                return intValue;
            }

            return 0;
        }
    }
}
