using System.Xml.Serialization;

namespace ConfigUtility.Components
{
    [Serializable]
    public class ApplicationConfigurationData
    {
        public string? BaldurLuaPath { get; set; }
        public DateTime TimeSaved { get; set; } = DateTime.Now;
    }

    internal class ApplicationConfiguration
    {
        public static string ConfigurationFilePath
        {
            get
            {
                if (!Directory.Exists("Data"))
                    Directory.CreateDirectory("Data");

                return $@"Data\{nameof(ApplicationConfiguration)}.xml";
            }
        }

        public static bool Write(ApplicationConfigurationData configurationData)
        {
            try
            {
                using var Writer = new StreamWriter(ConfigurationFilePath);
                var Serializer = new XmlSerializer(typeof(ApplicationConfigurationData));

                Serializer.Serialize(Writer, configurationData);
            }
            catch (Exception ex)
            {
                Logger.LogLine(ex.Message, LogType.Exception);
                return false;
            }

            return true;
        }

        public static bool Load(out ApplicationConfigurationData configurationData)
        {
            configurationData = new();

            try
            {
                if (!File.Exists(ConfigurationFilePath))
                    return false;

                using var Reader = new StreamReader(ConfigurationFilePath);
                var Serializer = new XmlSerializer(typeof(ApplicationConfigurationData));

                configurationData = (ApplicationConfigurationData)Serializer.Deserialize(Reader);
            }
            catch (Exception ex)
            {
                Logger.LogLine(ex.Message, LogType.Exception);
                return false;
            }

            return true;
        }
    }
}
