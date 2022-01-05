using System.Diagnostics;

namespace ConfigUtility
{
    public class Tools
    {
        public static bool IsProcessRunning(string ProcessName)
        {
            return Process.GetProcessesByName(ProcessName).Length > 0;
        }
    }
}
