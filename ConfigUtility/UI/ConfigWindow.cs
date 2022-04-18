using ConfigUtility.Components;

namespace ConfigUtility.UI
{
    public delegate void GameFoundHandler(string ShortGameName, string LongGameName);
    public delegate void UtilityClosedHandler();

    public partial class ConfigWindow : BaseWindow
    {
        private ApplicationConfigurationData Config = new();
        private string ConfigFileName => "Baldur.lua";

        public string ShortGameName { get; init; }
        public string LongGameName { get; init; }

        private ConfigBackupManager ConfigBackupManager { get; set; }
        private bool FullBackupExists => this.ConfigBackupManager.BackupExists;

        public event GameFoundHandler? GameFound;
        public event UtilityClosedHandler? UtilityClosed;

        private BaldurPropertyManager BaldurPropertyManager { get; set; }
        private bool LuaConfigAvailable => BaldurPropertyManager.ConfigFileExists;

        readonly Dictionary<int, string> Graphics_Properties = new()
        {
            { 0, "Graphics,Scale UI" },
            { 1, "Graphics,Show Black Space" },
            { 2, "Graphics,Hardware Mouse Cursor" },
            { 3, "Graphics,Greyscale On Pause" },
            { 4, "Graphics,Area Map Zoom" },
            { 5, "Graphics,Use Sprite Outlines" },
            { 6, "Graphics,Use Character Highlights" },
            { 7, "Graphics,Zoom Lock" },
            { 8, "Graphics,Backend" },
            { 9, "Graphics,Use Nearest Neighbour Scaling" },
            { 10, "Graphics,Maximized" },
            { 11, "Graphics,Full Screen" }
        };

        readonly Dictionary<int, string> Multiplayer_Properties = new()
        {
            { 0, "Multiplayer,Disable Banters" },
            { 1, "Multiplayer,Enable Chat Menu" }
        };

        readonly Dictionary<int, string> ProgramOptionsOne_Properties = new()
        {
            { 0, "Program Options,Translucent Shadows" },
            { 1, "Program Options,Never Show Nuisance SOD" },
            { 2, "Program Options,Display Subtitles" },
            { 3, "Program Options,Sprite Mirror" },
            { 4, "Program Options,Drop Capitals" },
            { 5, "Program Options,3D Acceleration" },
            { 6, "Program Options,Debug Mode" },
            { 7, "Program Options,Disable Cosmetic Attacks" },
            { 8, "Game Options,Pausing Map" },
            { 9, "Game Options,Sprite Mirror" },
            { 10, "Game Options,Sprite Mirror" },
            { 11, "Game Options,Sprite Mirror" },
            { 12, "Game Options,Sprite Mirror" },
            { 13, "Game Options,Show Character HP" },
            { 14, "Game Options,No Difficulty Based XP Bonus" },
            { 15, "Game Options,Infravision" },
            { 16, "Game Options,Render Explored Map" },
            { 17, "Game Options,3E Thief Sneak Attack" }
        };

        readonly Dictionary<int, string> ProgramOptionsTwo_Properties = new()
        {
            { 0, "Game Options,Nightmare Bonus Gold" },
            { 1, "Game Options,Always Dither" },
            { 2, "Game Options,HP Over Head" },
            { 3, "Game Options,Footsteps" },
            { 4, "Game Options,Attack Sounds" },
            { 5, "Game Options,Expire Trap Highlights" },
            { 6, "Game Options,Critical Hit Screen Shake" },
            { 7, "Game Options,Subtitles" },
            { 8, "Game Options,Combat UI" },
            { 9, "Game Options,Render Actions" },
            { 10, "Game Options,Environmental Audio" },
            { 11, "Game Options,Weather" },
            { 12, "Game Options,Classic Selection Circles" },
            { 13, "Game Options,Heal Party on Rest" },
            { 14, "Game Options,Terrain Hugging" },
            { 15, "Game Options,Color Circles" },
            { 16, "Game Options,Extra Feedback" },
            { 17, "Game Options,Cleric Ranger Spells" }
        };

        readonly Dictionary<int, string> ProgramOptionsThree_Properties = new()
        {
            { 0, "Game Options,Show Message Box Hint" },
            { 1, "Game Options,Show Learnable Spells" },
            { 2, "Game Options,Duplicate Floating Text" },
            { 3, "Game Options,Show AOE" },
            { 4, "Game Options,Render Travel Regions" },
            { 5, "Game Options,Quick Item Mapping" },
            { 6, "Game Options,Journal Popups" },
            { 7, "Game Options,Hotkeys On Tooltips" },
            { 8, "Game Options,All Learn Spell Info" },
            { 9, "Game Options,Equipment Comparison" },
            { 10, "Game Options,Confirm Dialog" },
            { 11, "Game Options,Suppress Extra Difficulty Damage" },
            { 12, "Game Options,Over Confirm Everything" },
            { 13, "Game Options,Tutorial State" },
            { 14, "Game Options,Filter Games" },
            { 15, "Game Options,Auto Pause State" },
            { 16, "Program Options,Cloud Saves Enabled" },
            { 17, "Program Options,Active Campaign" }
        };

        readonly Dictionary<int, string> ProgramOptionsExtendedOne_Properties = new()
        {
            { 0, "Program Options,Disable Movies" },
            { 1, "Program Options,UI Edit Mode" },
            { 2, "Program Options,Strref On" },
            { 3, "Game Options,Disable Foot Steps During Combat" },
        };

        readonly Dictionary<int, string> ProgramOptionsExtendedTwo_Properties = new()
        {
            { 0, "Game Options,Enable Fog" },
            { 1, "Game Options,Extra Combat Info" },
            { 2, "Game Options,Force Dialog Pause" },
            { 3, "Game Options,Enhanced Path Search" },
        };

        readonly Dictionary<int, string> ProgramOptionsExtendedThree_Properties = new()
        {
            { 0, "Game Options,Show Triggers On Tab" },
            { 1, "Game Options,Show Date On Pause" },
            { 2, "Game Options,Reverse Mouse Wheel Zoom" },
            { 3, "Game Options,Super Atomic Speed Fighting Action" },
        };

        public ConfigWindow(string ShortGameName, string LongGameName)
        {
            InitializeComponent();

            this.ShortGameName = ShortGameName;
            this.LongGameName = LongGameName;
        }

        // Methods

        private bool BackupConfiguration(bool Overwrite)
        {
            if (LuaConfigAvailable) return this.ConfigBackupManager.CreateBackup(null, Overwrite);
            return false;
        }

        private void UpdateUI()
        {
            if (BaldurPropertyManager is not null && LuaConfigAvailable)
            {
                // Update game speed section

                Int32 GameSpeed = 30;

                if (BaldurPropertyManager.GetProperty("Maximum Frame Rate", out var Speed))
                {
                    GameSpeed = Convert.ToInt32(Speed);
                }

                this.hScrollBar_GameSpeed.Value = GameSpeed;
                this.label_SpeedValueDisplay.Text = $"{GameSpeed} AI Updates / Sec";

                // Update the graphics section

                foreach (var PropertyString in Graphics_Properties)
                {
                    bool status = false;

                    if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(PropertyString.Value), out var Value))
                    {
                        status = Convert.ToBoolean(Convert.ToInt16(Value));
                    }

                    checkedListBox_GraphicOptions.SetItemChecked(PropertyString.Key, status);
                }

                // Update multiplayer section

                foreach (var PropertyString in Multiplayer_Properties)
                {
                    bool status = false;

                    if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(PropertyString.Value), out var Value))
                    {
                        status = Convert.ToBoolean(Convert.ToInt16(Value));
                    }

                    checkedListBox_MultiplayerOptions.SetItemChecked(PropertyString.Key, status);
                }

                // Update program section - first block

                foreach (var PropertyString in ProgramOptionsOne_Properties)
                {
                    bool status = false;

                    if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(PropertyString.Value), out var Value))
                    {
                        status = Convert.ToBoolean(Convert.ToInt16(Value));
                    }

                    checkedListBox_ProgramOptionsOne.SetItemChecked(PropertyString.Key, status);
                }

                // Update program section - second block

                foreach (var PropertyString in ProgramOptionsTwo_Properties)
                {
                    bool status = false;

                    if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(PropertyString.Value), out var Value))
                    {
                        status = Convert.ToBoolean(Convert.ToInt16(Value));
                    }

                    checkedListBox_ProgramOptionsTwo.SetItemChecked(PropertyString.Key, status);
                }

                // Update program section - third block

                foreach (var PropertyString in ProgramOptionsThree_Properties)
                {
                    bool status = false;

                    if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(PropertyString.Value), out var Value))
                    {
                        status = Convert.ToBoolean(Convert.ToInt16(Value));
                    }

                    checkedListBox_ProgramOptionsThree.SetItemChecked(PropertyString.Key, status);
                }

                // Update extended program section - first block

                foreach (var PropertyString in ProgramOptionsExtendedOne_Properties)
                {
                    bool status = false;

                    if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(PropertyString.Value), out var Value))
                    {
                        status = Convert.ToBoolean(Convert.ToInt16(Value));
                    }

                    checkedListBox_ExtendedProgramConfigurationOne.SetItemChecked(PropertyString.Key, status);
                }

                // Update extended program section - second block

                foreach (var PropertyString in ProgramOptionsExtendedTwo_Properties)
                {
                    bool status = false;

                    if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(PropertyString.Value), out var Value))
                    {
                        status = Convert.ToBoolean(Convert.ToInt16(Value));
                    }

                    checkedListBox_ExtendedProgramConfigurationTwo.SetItemChecked(PropertyString.Key, status);
                }

                // Update extended program section - second block

                foreach (var PropertyString in ProgramOptionsExtendedThree_Properties)
                {
                    bool status = false;

                    if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(PropertyString.Value), out var Value))
                    {
                        status = Convert.ToBoolean(Convert.ToInt16(Value));
                    }

                    checkedListBox_ExtendedProgramConfigurationThree.SetItemChecked(PropertyString.Key, status);
                }
            }
        }

        private string? LocateGameConfig()
        {
            try
            {
                var BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                            LongGameName,
                                            ConfigFileName);

                if (BasePath is not null && File.Exists(BasePath))
                {
                    return BasePath;
                }

                Msg.Information($"Please point me to the location of your {ConfigFileName} file.");

                if (openFileDialog_SelectGameConfig.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetFileName(openFileDialog_SelectGameConfig.FileName) == ConfigFileName)
                        return openFileDialog_SelectGameConfig.FileName;
                }
            }
            catch (Exception ex)
            {
                Logger.LogLine(ex.Message, LogType.Exception);
            }

            return null;
        }

        // Event handlers

        private void HScrollBar_GameSpeed_ValueChanged(object sender, EventArgs e)
        {
            var SelectedSpeedValue = ((HScrollBar)sender).Value.ToString();

            // Update UI
            this.label_SpeedValueDisplay.Text = $"{SelectedSpeedValue} AI Updates / Sec";

            // Update value
            this.BaldurPropertyManager?.SetProperty("Program Options", "Maximum Frame Rate", SelectedSpeedValue);
        }

        private void ConfigWindow_Load(object sender, EventArgs e)
        {
            if(ApplicationConfiguration.Load(out var config))
            {
                this.Config = config;
            }
            else
            {
                this.Config.BaldurLuaPath = LocateGameConfig();
                ApplicationConfiguration.Write(Config);
            }

            if (this.Config.BaldurLuaPath is null)
            {
                Msg.Information($"The configuration file was not found for {ShortGameName}. Ensure that the game is installed and was started at least once.\n\n" +
                    $"The program will now quit.");

                Application.Exit();
            }
            else
            {
                this.ConfigBackupManager = new(this.Config.BaldurLuaPath, "Configuration");
                this.BaldurPropertyManager = new(this.Config.BaldurLuaPath);

                this.Text = $"{LongGameName} - Configuration";

                this.GameFound += ConfigWindow_GameFound;
                this.UtilityClosed += ConfigWindow_UtilityClosed;

                if (BaldurPropertyManager.ConfigFileExists)
                {
                    this.label_GameConfigNameStatus.Text = $"{ShortGameName} Config Found";
                    this.label_GameConfigNameStatus.ForeColor = Color.LimeGreen;

                    this.GameFound?.Invoke(ShortGameName, LongGameName);
                }
                else
                {
                    this.label_GameConfigNameStatus.Text = $"{ShortGameName} Config Not Found";
                    this.label_GameConfigNameStatus.ForeColor = Color.Red;
                }

                if (!FullBackupExists)
                {
                    // Do not overwrite any existing backups on load

                    if (BackupConfiguration(false))
                        Msg.Information("Configuration has been backed up successfully.");
                    else
                        Msg.Warning("Configuration has not been backed up.");
                }
            }
        }

        private void ConfigWindow_GameFound(string ShortGameName, string LongGameName)
        {
            checkedListBox_GraphicOptions.Enabled = true;
            checkedListBox_MultiplayerOptions.Enabled = true;
            checkedListBox_ProgramOptionsOne.Enabled = true;
            checkedListBox_ProgramOptionsTwo.Enabled = true;
            checkedListBox_ProgramOptionsThree.Enabled = true;
            checkedListBox_ExtendedProgramConfigurationOne.Enabled = true;
            checkedListBox_ExtendedProgramConfigurationTwo.Enabled = true;
            checkedListBox_ExtendedProgramConfigurationThree.Enabled = true;

            hScrollBar_GameSpeed.Enabled = true;

            this.UpdateUI();
        }

        private void ConfigWindow_UtilityClosed()
        {
            this.Close();
        }

        private void CheckedListBox_GraphicOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && Graphics_Properties.TryGetValue(e.Index, out var S))
                BaldurPropertyManager.SetBoolean(S, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_MultiplayerOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && Multiplayer_Properties.TryGetValue(e.Index, out var S))
                BaldurPropertyManager.SetBoolean(S, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ProgramOptionsOne_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsOne_Properties.TryGetValue(e.Index, out var S))
                BaldurPropertyManager.SetBoolean(S, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ProgramOptionsTwo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsTwo_Properties.TryGetValue(e.Index, out var S))
                BaldurPropertyManager.SetBoolean(S, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ProgramOptionsThree_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsThree_Properties.TryGetValue(e.Index, out var S))
                BaldurPropertyManager.SetBoolean(S, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilityClosed?.Invoke();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LuaConfigAvailable)
            {
                this.UpdateUI();
                Msg.Information("Option status has been refreshed!");
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to create a new backup?\n\nAny existing backup will be overwritten.",
                                                    "Information",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Asterisk))
            {
                if (BackupConfiguration(true))
                {
                    Msg.Information($"Backup successfully created!");
                    this.UpdateUI();
                }
                else
                {
                    Msg.Information($"Backup creation failed!");
                }
            }
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show($"{ConfigFileName} will be restored.",
                                                    "Information",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Asterisk))
            {
                if (ConfigBackupManager.RestoreBackup())
                {
                    Msg.Information($"Backup successfully restored!");
                    this.UpdateUI();
                }
                else
                {
                    Msg.Information($"Cannot restore backup!");
                }
            }
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfigBackupManager.BackupExists)
            {
                var CT = File.GetCreationTime(ConfigBackupManager.BackupFilePath);
                Msg.Information($"Backup file for {ShortGameName} exists!\n\nCreated at: {CT}", "Backup Status");
            }
            else
            {
                Msg.Information($"Backup file for {ShortGameName} does not exist!", "Backup Status");
            }
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var About = new AboutWindow();
            About.ShowDialog();
        }

        private void CheckedListBox_ExtendedProgramConfigurationOne_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsExtendedOne_Properties.TryGetValue(e.Index, out var S))
                BaldurPropertyManager.SetBoolean(S, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ExtendedProgramConfigurationTwo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsExtendedTwo_Properties.TryGetValue(e.Index, out var S))
                BaldurPropertyManager.SetBoolean(S, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ExtendedProgramConfigurationThree_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsExtendedThree_Properties.TryGetValue(e.Index, out var S))
                BaldurPropertyManager.SetBoolean(S, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void WriteOptimalConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BaldurPropertyManager == null)
            {
                Msg.Error("Cannot access game configuration properties.");
                return;
            }

            var text = "The following changes will be written:\n\n"
                       + "- Set game speed to 40 AI Updates / Sec\n"
                       + "- Enable footsteps during combat\n"
                       + "- Enable date showing on pause\n"
                       + "- Enable enhanced path search\n"
                       + "- Disable cosmetic attacks\n\n"
                       + "Select OK to make changes.";

            if (DialogResult.OK == MessageBox.Show(text, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                BaldurPropertyManager.SetProperty("Program Options", "Maximum Frame Rate", "40");
                BaldurPropertyManager.SetBoolean("Game Options,Disable Foot Steps During Combat", false);
                BaldurPropertyManager.SetBoolean("Game Options,Show Date On Pause", true);
                BaldurPropertyManager.SetBoolean("Game Options,Enhanced Path Search", true);
                BaldurPropertyManager.SetBoolean("Program Options,Disable Cosmetic Attacks", true);

                this.UpdateUI();

                Msg.Information("Configuration written!");
            }
        }

        private void ExtendedConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdditionalOptions(this.BaldurPropertyManager).ShowDialog();
        }
    }
}