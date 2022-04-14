using System.Diagnostics;

namespace ConfigUtility.Components
{
    public class ProcessTools
    {
        public static bool IsProcessRunning(string ProcessName)
        {
            return Process.GetProcessesByName(ProcessName).Length > 0;
        }
    }
}
