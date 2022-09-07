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
                var backupFolderPath = Path.Combine(Application.StartupPath, "Backup");

                if (!Directory.Exists(backupFolderPath))
                    Directory.CreateDirectory(backupFolderPath);

                return Path.Combine(backupFolderPath, $"{GameIdentifier}.lua.backup");
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

        public bool CreateBackup(string? saveLocation = null, bool overwrite = true)
        {
            try
            {
                if (string.IsNullOrEmpty(saveLocation))
                {
                    saveLocation = BackupFilePath;
                }

                if (File.Exists(LuaConfigFilePath))
                    File.Copy(LuaConfigFilePath, saveLocation, overwrite);

                return true;
            }
            catch (Exception ex)
            {
                Logger.LogLine(ex.Message, LogType.Exception);
                return false;
            }
        }

        public bool RestoreBackup(string? sourceLocation = null)
        {
            try
            {
                if (string.IsNullOrEmpty(sourceLocation))
                {
                    sourceLocation = BackupFilePath;
                }

                if (File.Exists(sourceLocation) == false)
                    return false;

                File.Copy(sourceLocation, LuaConfigFilePath, true);

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
