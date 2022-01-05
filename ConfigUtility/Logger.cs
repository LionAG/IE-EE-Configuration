using System.Reflection;

namespace ConfigUtility
{
    public enum LogType
    {
        Error,
        Exception,
        Information
    }

    internal class Logger
    {
        public static bool IncludeTimestamp { get; set; } = true;
        public static string LogFilename
        {
            get
            {
                return $"{Assembly.GetExecutingAssembly().GetName().Name}_Log.txt";
            }
        }

        public static void DeleteLogFile()
        {
            File.Delete(LogFilename);
        }

        public static string GetLine(string msg, LogType logType)
        {
            string? ECName; // Name of the enumeration constant

            if ((ECName = Enum.GetName(logType.GetType(), logType)) != null)
            {
                var TypeName = ECName.ToString().ToUpper();

                if (IncludeTimestamp)
                    return msg.Insert(0, $"[{DateTime.Now}] [{TypeName}]");

                return $"[{TypeName}] {msg}";
            }

            return msg;
        }

        public static bool Log(string msg, LogType logType)
        {
            if (string.IsNullOrEmpty(msg))
            {
                throw new ArgumentException($"'{nameof(msg)}' cannot be null or empty.", nameof(msg));
            }

            try
            {
                File.AppendAllLines(LogFilename, new string[] { GetLine(msg, logType) });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool LogLine(string msg, LogType logType)
        {
            if (string.IsNullOrEmpty(msg))
            {
                throw new ArgumentException($"'{nameof(msg)}' cannot be null or empty.", nameof(msg));
            }

            try
            {
                File.AppendAllLines(LogFilename, new string[] { $"{GetLine(msg, logType)}\n" });
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
