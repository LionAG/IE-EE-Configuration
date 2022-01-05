using ConfigUtility;
using ConfigUtility.UI;

namespace BGIEEConfig
{
    internal static class Program
    {
        public static readonly string GameProcessName = "Baldur";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (Tools.IsProcessRunning(GameProcessName))
            {
                Msg.Error("Please close Baldur's Gate while using the configuration utility.");
                return;
            }

            Application.Run(new ConfigWindow("BG:EE", "Baldur's Gate - Enhanced Edition"));
        }
    }
}