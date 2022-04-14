using ConfigUtility.Components;
using ConfigUtility.UI;

namespace BGIIEEConfig
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

            if (ProcessTools.IsProcessRunning(GameProcessName))
            {
                Msg.Error("Please close Baldur's Gate while using the configuration utility.");
                return;
            }

            Application.Run(new ConfigWindow("BGII:EE", "Baldur's Gate II - Enhanced Edition"));
        }
    }
}