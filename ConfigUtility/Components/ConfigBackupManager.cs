namespace ConfigUtility.Components
{
    public class ConfigBackupManager
    {
        private string LuaConfigFilePath { get; init; }
        private string GameIdentifier { get; init; }

        public bool BackupExists => File.Exists(BackupFilePath);

        public string BackupFilePath
        {
            get
            {
                var BackupFolderPath = Path.Combine(Application.StartupPath, "Backup");

                if (!Directory.Exists(BackupFolderPath))
                    Directory.CreateDirectory(BackupFolderPath);

                return Path.Combine(BackupFolderPath, $"{GameIdentifier}.lua.backup");
            }
        }

        public ConfigBackupManager(string LuaConfigFilePath, string GameIdentifier)
        {
            if (string.IsNullOrEmpty(LuaConfigFilePath))
            {
                throw new ArgumentException($"'{nameof(LuaConfigFilePath)}' cannot be null or empty.", nameof(LuaConfigFilePath));
            }

            if (string.IsNullOrEmpty(GameIdentifier))
            {
                throw new ArgumentException($"'{nameof(GameIdentifier)}' cannot be null or empty.", nameof(GameIdentifier));
            }

            this.LuaConfigFilePath = LuaConfigFilePath;
            this.GameIdentifier = GameIdentifier;
        }

        public bool CreateBackup(string? SaveLocation = null, bool Overwrite = true)
        {
            try
            {
                if (string.IsNullOrEmpty(SaveLocation))
                {
                    SaveLocation = BackupFilePath;
                }

                if (File.Exists(SaveLocation) == false)
                    File.Copy(LuaConfigFilePath, SaveLocation, Overwrite);

                return true;
            }
            catch (Exception ex)
            {
                Logger.LogLine(ex.Message, LogType.Exception);
                return false;
            }
        }

        public bool RestoreBackup(string? SourceLocation = null)
        {
            try
            {
                if (string.IsNullOrEmpty(SourceLocation))
                {
                    SourceLocation = BackupFilePath;
                }

                if (File.Exists(SourceLocation) == false)
                    return false;

                File.Copy(SourceLocation, LuaConfigFilePath, true);

                return true;
            }
            catch (Exception ex)
            {
                Logger.LogLine(ex.Message, LogType.Exception);
                return false;
            }
        }
    }
}
