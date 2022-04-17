namespace ConfigUtility.Components
{
    public class BaldurPropertyManager
    {
        private readonly string LuaFilePath;

        public bool ConfigFileExists => File.Exists(LuaFilePath);

        public BaldurPropertyManager(string LuaFilePath)
        {
            if (string.IsNullOrEmpty(LuaFilePath))
            {
                throw new ArgumentException($"'{nameof(LuaFilePath)}' cannot be null or empty.", nameof(LuaFilePath));
            }

            if (!File.Exists(LuaFilePath))
            {
                throw new FileNotFoundException($"{LuaFilePath} - file does not exist.");
            }

            this.LuaFilePath = LuaFilePath;
        }

        private static string CreateEntry(string Section, string Property, string Value)
        {
            return $"SetPrivateProfileString('{Section}','{Property}','{Value}')";
        }

        public bool SetProperty(string Section, string PropertyName, string Value)
        {
            if (ConfigFileExists)
            {
                try
                {
                    var ConfigContent = new List<string>(File.ReadAllLines(LuaFilePath));
                    var Line = ConfigContent.Find(l => l.Contains(PropertyName));

                    if (Line is null)
                    {
                        ConfigContent.Insert(ConfigContent.Count, CreateEntry(Section, PropertyName, Value));
                    }
                    else
                    {
                        var S = Line.Split(',');
                        var ValueStr = $"'{Value}')";

                        var LineIndex = ConfigContent.IndexOf(Line);
                        var ModifiedLine = $"{S[0]},{S[1]},{ValueStr}";

                        ConfigContent.Remove(Line); // Remove line
                        ConfigContent.Insert(LineIndex, ModifiedLine);  // Insert modified line
                    }

                    File.WriteAllLines(this.LuaFilePath, ConfigContent);
                    return true;
                }
                catch (Exception ex)
                {
                    Logger.LogLine(ex.Message, LogType.Exception);
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PropertyName"></param>
        /// <param name="Value"></param>
        /// <returns>Property value or "Not found" string</returns>
        public bool GetProperty(string PropertyName, out string Value)
        {
            if (ConfigFileExists)
            {
                try
                {
                    var ConfigContent = new List<string>(File.ReadAllLines(LuaFilePath));
                    var Line = ConfigContent.Find(l => l.Contains(PropertyName));

                    if (Line != null)
                    {
                        Value = Line.Split(',')[2].Replace("'", "").Replace(")", "");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogLine(ex.Message, LogType.Exception);
                }
            }

            Value = "Not found";
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PropertyString">eg. "Graphics,Scale UI"</param>
        /// <param name="value">Value to set</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool SetByPropertyString(string PropertyString, string value)
        {
            if (string.IsNullOrEmpty(PropertyString))
            {
                throw new ArgumentException($"'{nameof(PropertyString)}' cannot be null or empty.", nameof(PropertyString));
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"'{nameof(value)}' cannot be null or empty.", nameof(value));
            }

            var Section = GetSectionName(PropertyString);
            var Property = GetPropertyName(PropertyString);

            return this.SetProperty(Section, Property, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PropertyString">eg. "Graphics,Scale UI"</param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool SetBoolean(string PropertyString, bool Value)
        {
            if (string.IsNullOrEmpty(PropertyString))
            {
                return false;
            }

            return SetByPropertyString(PropertyString, Value ? "1" : "0");
        }

        /// <summary>
        /// Pass a string eg. "Graphics,Scale UI" -> will return "Graphics"
        /// </summary>
        /// <param name="PropertyString"></param>
        /// <returns></returns>
        public static string GetSectionName(string PropertyString)
        {
            return PropertyString.Split(',')[0];
        }

        /// <summary>
        /// Pass a string eg. "Graphics,Scale UI" -> will return "Scale UI"
        /// </summary>
        /// <param name="PropertyString"></param>
        /// <returns></returns>
        public static string GetPropertyName(string PropertyString)
        {
            return PropertyString.Split(',')[1];
        }
    }
}