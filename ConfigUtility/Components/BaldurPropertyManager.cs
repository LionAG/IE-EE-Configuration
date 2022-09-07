namespace ConfigUtility.Components
{
    public class BaldurPropertyManager
    {
        private readonly string LuaFilePath;

        public bool ConfigFileExists => File.Exists(LuaFilePath);

        public BaldurPropertyManager(string luaFilePath)
        {
            if (string.IsNullOrEmpty(luaFilePath))
            {
                throw new ArgumentException($"'{nameof(luaFilePath)}' cannot be null or empty.", nameof(luaFilePath));
            }

            if (!File.Exists(luaFilePath))
            {
                throw new FileNotFoundException($"{luaFilePath} - file does not exist.");
            }

            this.LuaFilePath = luaFilePath;
        }

        private static string CreateEntry(string section, string property, string value)
        {
            return $"SetPrivateProfileString('{section}','{property}','{value}')";
        }

        public bool SetProperty(string section, string propertyName, string value)
        {
            if (ConfigFileExists)
            {
                try
                {
                    var configContent = new List<string>(File.ReadAllLines(LuaFilePath));
                    var line = configContent.Find(l => l.Contains(propertyName));

                    if (line is null)
                    {
                        configContent.Insert(configContent.Count, CreateEntry(section, propertyName, value));
                    }
                    else
                    {
                        var s = line.Split(',');
                        var valueStr = $"'{value}')";

                        var lineIndex = configContent.IndexOf(line);
                        var modifiedLine = $"{s[0]},{s[1]},{valueStr}";

                        configContent.Remove(line); // Remove line
                        configContent.Insert(lineIndex, modifiedLine);  // Insert modified line
                    }

                    File.WriteAllLines(this.LuaFilePath, configContent);
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
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <returns>Property value or "Not found" string</returns>
        public bool GetProperty(string propertyName, out string value)
        {
            if (ConfigFileExists)
            {
                try
                {
                    var configContent = new List<string>(File.ReadAllLines(LuaFilePath));
                    var line = configContent.Find(l => l.Contains(propertyName));

                    if (line != null)
                    {
                        value = line.Split(',')[2].Replace("'", "").Replace(")", "");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogLine(ex.Message, LogType.Exception);
                }
            }

            value = "Not found";
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyString">eg. "Graphics,Scale UI"</param>
        /// <param name="value">Value to set</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool SetByPropertyString(string propertyString, string value)
        {
            if (string.IsNullOrEmpty(propertyString))
            {
                throw new ArgumentException($"'{nameof(propertyString)}' cannot be null or empty.", nameof(propertyString));
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"'{nameof(value)}' cannot be null or empty.", nameof(value));
            }

            var section = GetSectionName(propertyString);
            var property = GetPropertyName(propertyString);

            return this.SetProperty(section, property, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyString">eg. "Graphics,Scale UI"</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetBoolean(string propertyString, bool value)
        {
            if (string.IsNullOrEmpty(propertyString))
            {
                return false;
            }

            return SetByPropertyString(propertyString, value ? "1" : "0");
        }

        /// <summary>
        /// Pass a string eg. "Graphics,Scale UI" -> will return "Graphics"
        /// </summary>
        /// <param name="propertyString"></param>
        /// <returns></returns>
        public static string GetSectionName(string propertyString)
        {
            return propertyString.Split(',')[0];
        }

        /// <summary>
        /// Pass a string eg. "Graphics,Scale UI" -> will return "Scale UI"
        /// </summary>
        /// <param name="propertyString"></param>
        /// <returns></returns>
        public static string GetPropertyName(string propertyString)
        {
            return propertyString.Split(',')[1];
        }
    }
}