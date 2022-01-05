using ConfigUtility;
using ConfigUtility.UI;

namespace PSTEEConfig
{
    internal static class Program
    {
        public static readonly string GameProcessName = "Torment";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (Tools.IsProcessRunning(GameProcessName))
            {
                Msg.Error("Please close Planescape: Torment while using the configuration utility.");
                return;
            }

            Application.Run(new ConfigWindow("PST:EE", "Planescape Torment - Enhanced Edition"));
        }
    }
}