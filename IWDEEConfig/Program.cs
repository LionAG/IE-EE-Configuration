using ConfigUtility;
using ConfigUtility.UI;
using ConfigUtility.Components;

namespace IWDEEConfig
{
    internal static class Program
    {
        public static readonly string GameProcessName = "icewind";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (ProcessTools.IsProcessRunning(GameProcessName))
            {
                Msg.Error("Please close Icewind Dale while using the configuration utility.");
                return;
            }

            Application.Run(new ConfigWindow("IWD:EE", "Icewind Dale - Enhanced Edition"));
        }
    }
}