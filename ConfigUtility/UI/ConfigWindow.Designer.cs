namespace ConfigUtility.UI
{
    partial class ConfigWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox_GraphicOptions = new System.Windows.Forms.CheckedListBox();
            this.panel_GraphicOptions = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_SpeedValueDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar_GameSpeed = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkedListBox_ProgramOptionsThree = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_ProgramOptionsTwo = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox_ProgramOptionsOne = new System.Windows.Forms.CheckedListBox();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkedListBox_ExtendedProgramConfigurationThree = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_ExtendedProgramConfigurationTwo = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_ExtendedProgramConfigurationOne = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.checkedListBox_MultiplayerOptions = new System.Windows.Forms.CheckedListBox();
            this.panel_GameConfigStatus = new System.Windows.Forms.Panel();
            this.label_GameConfigNameStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeOptimalConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_SelectGameConfig = new System.Windows.Forms.OpenFileDialog();
            this.panel_GraphicOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Content.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_GameConfigStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox_GraphicOptions
            // 
            this.checkedListBox_GraphicOptions.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_GraphicOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_GraphicOptions.CheckOnClick = true;
            this.checkedListBox_GraphicOptions.Enabled = false;
            this.checkedListBox_GraphicOptions.FormattingEnabled = true;
            this.checkedListBox_GraphicOptions.Items.AddRange(new object[] {
            "Enable UI Scaling",
            "Show Black Space",
            "Hardware Mouse Cursor",
            "Greyscale On Pause",
            "Area Map Zoom",
            "Use Sprite Outlines",
            "Use Character Highlights",
            "Zoom Lock",
            "Backend",
            "Use Nearest Neighbour Scaling",
            "Window - Maximized",
            "Window - Fullscreen"});
            this.checkedListBox_GraphicOptions.Location = new System.Drawing.Point(10, 31);
            this.checkedListBox_GraphicOptions.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_GraphicOptions.Name = "checkedListBox_GraphicOptions";
            this.checkedListBox_GraphicOptions.Size = new System.Drawing.Size(211, 216);
            this.checkedListBox_GraphicOptions.TabIndex = 1;
            this.checkedListBox_GraphicOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_GraphicOptions_ItemCheck);
            // 
            // panel_GraphicOptions
            // 
            this.panel_GraphicOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_GraphicOptions.Controls.Add(this.panel1);
            this.panel_GraphicOptions.Controls.Add(this.label1);
            this.panel_GraphicOptions.Controls.Add(this.checkedListBox_GraphicOptions);
            this.panel_GraphicOptions.Location = new System.Drawing.Point(6, 22);
            this.panel_GraphicOptions.Margin = new System.Windows.Forms.Padding(2);
            this.panel_GraphicOptions.Name = "panel_GraphicOptions";
            this.panel_GraphicOptions.Size = new System.Drawing.Size(231, 367);
            this.panel_GraphicOptions.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_SpeedValueDisplay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hScrollBar_GameSpeed);
            this.panel1.Location = new System.Drawing.Point(10, 261);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 83);
            this.panel1.TabIndex = 3;
            // 
            // label_SpeedValueDisplay
            // 
            this.label_SpeedValueDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_SpeedValueDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_SpeedValueDisplay.Location = new System.Drawing.Point(0, 56);
            this.label_SpeedValueDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SpeedValueDisplay.Name = "label_SpeedValueDisplay";
            this.label_SpeedValueDisplay.Size = new System.Drawing.Size(209, 25);
            this.label_SpeedValueDisplay.TabIndex = 5;
            this.label_SpeedValueDisplay.Text = "30 AI Updates / Sec";
            this.label_SpeedValueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label2.Size = new System.Drawing.Size(209, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "GAME SPEED";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hScrollBar_GameSpeed
            // 
            this.hScrollBar_GameSpeed.Enabled = false;
            this.hScrollBar_GameSpeed.Location = new System.Drawing.Point(5, 31);
            this.hScrollBar_GameSpeed.Maximum = 69;
            this.hScrollBar_GameSpeed.Minimum = 15;
            this.hScrollBar_GameSpeed.Name = "hScrollBar_GameSpeed";
            this.hScrollBar_GameSpeed.Size = new System.Drawing.Size(199, 26);
            this.hScrollBar_GameSpeed.TabIndex = 3;
            this.hScrollBar_GameSpeed.Value = 30;
            this.hScrollBar_GameSpeed.ValueChanged += new System.EventHandler(this.HScrollBar_GameSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRAPHICS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.checkedListBox_ProgramOptionsThree);
            this.panel4.Controls.Add(this.checkedListBox_ProgramOptionsTwo);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.checkedListBox_ProgramOptionsOne);
            this.panel4.Location = new System.Drawing.Point(256, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(727, 366);
            this.panel4.TabIndex = 4;
            // 
            // checkedListBox_ProgramOptionsThree
            // 
            this.checkedListBox_ProgramOptionsThree.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_ProgramOptionsThree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_ProgramOptionsThree.CheckOnClick = true;
            this.checkedListBox_ProgramOptionsThree.Enabled = false;
            this.checkedListBox_ProgramOptionsThree.FormattingEnabled = true;
            this.checkedListBox_ProgramOptionsThree.Items.AddRange(new object[] {
            "Show Message Box Hint",
            "Show Learnable Spells",
            "Duplicate Floating Text",
            "Show AOE",
            "Render Travel Regions",
            "Quick Item Mapping",
            "Journal Popups",
            "Hotkeys On Tooltips",
            "All Learn Spell Info",
            "Equipment Comparison",
            "Confirm Dialog",
            "Suppress Extra Difficulty Damage",
            "Over Confirm Everything",
            "Tutorial State",
            "Filter Games",
            "Auto Pause State",
            "Cloud Saves Enabled",
            "Active Campaign"});
            this.checkedListBox_ProgramOptionsThree.Location = new System.Drawing.Point(485, 29);
            this.checkedListBox_ProgramOptionsThree.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_ProgramOptionsThree.Name = "checkedListBox_ProgramOptionsThree";
            this.checkedListBox_ProgramOptionsThree.Size = new System.Drawing.Size(211, 324);
            this.checkedListBox_ProgramOptionsThree.TabIndex = 4;
            this.checkedListBox_ProgramOptionsThree.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_ProgramOptionsThree_ItemCheck);
            // 
            // checkedListBox_ProgramOptionsTwo
            // 
            this.checkedListBox_ProgramOptionsTwo.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_ProgramOptionsTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_ProgramOptionsTwo.CheckOnClick = true;
            this.checkedListBox_ProgramOptionsTwo.Enabled = false;
            this.checkedListBox_ProgramOptionsTwo.FormattingEnabled = true;
            this.checkedListBox_ProgramOptionsTwo.Items.AddRange(new object[] {
            "Nightmare Bonus Gold",
            "Always Dither",
            "HP Over Head",
            "Footsteps",
            "Attack Sounds",
            "Expire Trap Highlights",
            "Critical Hit Screen Shake",
            "Subtitles",
            "Combat UI",
            "Render Actions",
            "Environmental Audio",
            "Weather",
            "Classic Selection Circles",
            "Heal Party On Rest",
            "Terrain Hugging",
            "Color Circles",
            "Extra Feedback",
            "Cleric Ranger Spells"});
            this.checkedListBox_ProgramOptionsTwo.Location = new System.Drawing.Point(258, 30);
            this.checkedListBox_ProgramOptionsTwo.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_ProgramOptionsTwo.Name = "checkedListBox_ProgramOptionsTwo";
            this.checkedListBox_ProgramOptionsTwo.Size = new System.Drawing.Size(211, 324);
            this.checkedListBox_ProgramOptionsTwo.TabIndex = 3;
            this.checkedListBox_ProgramOptionsTwo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_ProgramOptionsTwo_ItemCheck);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(725, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "PROGRAM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox_ProgramOptionsOne
            // 
            this.checkedListBox_ProgramOptionsOne.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_ProgramOptionsOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_ProgramOptionsOne.CheckOnClick = true;
            this.checkedListBox_ProgramOptionsOne.Enabled = false;
            this.checkedListBox_ProgramOptionsOne.FormattingEnabled = true;
            this.checkedListBox_ProgramOptionsOne.Items.AddRange(new object[] {
            "Translucent Shadows",
            "Never Show Nuisance SOD",
            "Display Subtitles",
            "Sprite Mirror",
            "Drop Capitals",
            "3D Acceleration",
            "Debug Mode",
            "Disable Cosmetic Attacks",
            "Pausing Map",
            "Ranged Weapon Switching",
            "Nightmare Bonus XP",
            "Auto Pause Center",
            "Maximum HP",
            "Show Character HP",
            "No Difficulty Based XP Bonus",
            "Infravision",
            "Render Explored Map",
            "3E Thief Sneak Attack"});
            this.checkedListBox_ProgramOptionsOne.Location = new System.Drawing.Point(30, 30);
            this.checkedListBox_ProgramOptionsOne.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_ProgramOptionsOne.Name = "checkedListBox_ProgramOptionsOne";
            this.checkedListBox_ProgramOptionsOne.Size = new System.Drawing.Size(211, 324);
            this.checkedListBox_ProgramOptionsOne.TabIndex = 1;
            this.checkedListBox_ProgramOptionsOne.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_ProgramOptionsOne_ItemCheck);
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.panel6);
            this.panel_Content.Controls.Add(this.panel3);
            this.panel_Content.Controls.Add(this.panel_GameConfigStatus);
            this.panel_Content.Controls.Add(this.label3);
            this.panel_Content.Controls.Add(this.panel4);
            this.panel_Content.Controls.Add(this.panel_GraphicOptions);
            this.panel_Content.Controls.Add(this.menuStrip1);
            this.panel_Content.Location = new System.Drawing.Point(2, 2);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(989, 588);
            this.panel_Content.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(256, 407);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(727, 146);
            this.panel6.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkedListBox_ExtendedProgramConfigurationThree);
            this.panel2.Controls.Add(this.checkedListBox_ExtendedProgramConfigurationTwo);
            this.panel2.Controls.Add(this.checkedListBox_ExtendedProgramConfigurationOne);
            this.panel2.Location = new System.Drawing.Point(-1, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 114);
            this.panel2.TabIndex = 5;
            // 
            // checkedListBox_ExtendedProgramConfigurationThree
            // 
            this.checkedListBox_ExtendedProgramConfigurationThree.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_ExtendedProgramConfigurationThree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_ExtendedProgramConfigurationThree.CheckOnClick = true;
            this.checkedListBox_ExtendedProgramConfigurationThree.Enabled = false;
            this.checkedListBox_ExtendedProgramConfigurationThree.FormattingEnabled = true;
            this.checkedListBox_ExtendedProgramConfigurationThree.Items.AddRange(new object[] {
            "Show Triggers On Tab",
            "Show Date On Pause",
            "Reverse Mouse Wheel Zoom",
            "Super Atomic Speed Fighting Action"});
            this.checkedListBox_ExtendedProgramConfigurationThree.Location = new System.Drawing.Point(476, 19);
            this.checkedListBox_ExtendedProgramConfigurationThree.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_ExtendedProgramConfigurationThree.Name = "checkedListBox_ExtendedProgramConfigurationThree";
            this.checkedListBox_ExtendedProgramConfigurationThree.Size = new System.Drawing.Size(224, 72);
            this.checkedListBox_ExtendedProgramConfigurationThree.TabIndex = 6;
            this.checkedListBox_ExtendedProgramConfigurationThree.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_ExtendedProgramConfigurationThree_ItemCheck);
            // 
            // checkedListBox_ExtendedProgramConfigurationTwo
            // 
            this.checkedListBox_ExtendedProgramConfigurationTwo.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_ExtendedProgramConfigurationTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_ExtendedProgramConfigurationTwo.CheckOnClick = true;
            this.checkedListBox_ExtendedProgramConfigurationTwo.Enabled = false;
            this.checkedListBox_ExtendedProgramConfigurationTwo.FormattingEnabled = true;
            this.checkedListBox_ExtendedProgramConfigurationTwo.Items.AddRange(new object[] {
            "Enable Fog",
            "Extra Combat Info",
            "Force Dialog Pause",
            "Enhanced Path Search"});
            this.checkedListBox_ExtendedProgramConfigurationTwo.Location = new System.Drawing.Point(250, 19);
            this.checkedListBox_ExtendedProgramConfigurationTwo.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_ExtendedProgramConfigurationTwo.Name = "checkedListBox_ExtendedProgramConfigurationTwo";
            this.checkedListBox_ExtendedProgramConfigurationTwo.Size = new System.Drawing.Size(224, 72);
            this.checkedListBox_ExtendedProgramConfigurationTwo.TabIndex = 5;
            this.checkedListBox_ExtendedProgramConfigurationTwo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_ExtendedProgramConfigurationTwo_ItemCheck);
            // 
            // checkedListBox_ExtendedProgramConfigurationOne
            // 
            this.checkedListBox_ExtendedProgramConfigurationOne.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_ExtendedProgramConfigurationOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_ExtendedProgramConfigurationOne.CheckOnClick = true;
            this.checkedListBox_ExtendedProgramConfigurationOne.Enabled = false;
            this.checkedListBox_ExtendedProgramConfigurationOne.FormattingEnabled = true;
            this.checkedListBox_ExtendedProgramConfigurationOne.Items.AddRange(new object[] {
            "Disable Movies",
            "UI Edit Mode",
            "Strref On",
            "Disable Footsteps During Combat"});
            this.checkedListBox_ExtendedProgramConfigurationOne.Location = new System.Drawing.Point(22, 19);
            this.checkedListBox_ExtendedProgramConfigurationOne.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_ExtendedProgramConfigurationOne.Name = "checkedListBox_ExtendedProgramConfigurationOne";
            this.checkedListBox_ExtendedProgramConfigurationOne.Size = new System.Drawing.Size(224, 72);
            this.checkedListBox_ExtendedProgramConfigurationOne.TabIndex = 4;
            this.checkedListBox_ExtendedProgramConfigurationOne.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_ExtendedProgramConfigurationOne_ItemCheck);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(725, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "EXTENDED PROGRAM CONFIGURATION";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.checkedListBox_MultiplayerOptions);
            this.panel3.Location = new System.Drawing.Point(6, 408);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 73);
            this.panel3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "MULTIPLAYER";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox_MultiplayerOptions
            // 
            this.checkedListBox_MultiplayerOptions.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_MultiplayerOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_MultiplayerOptions.CheckOnClick = true;
            this.checkedListBox_MultiplayerOptions.Enabled = false;
            this.checkedListBox_MultiplayerOptions.FormattingEnabled = true;
            this.checkedListBox_MultiplayerOptions.Items.AddRange(new object[] {
            "Disable Banters",
            "Enable Chat Menu"});
            this.checkedListBox_MultiplayerOptions.Location = new System.Drawing.Point(10, 30);
            this.checkedListBox_MultiplayerOptions.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_MultiplayerOptions.Name = "checkedListBox_MultiplayerOptions";
            this.checkedListBox_MultiplayerOptions.Size = new System.Drawing.Size(211, 36);
            this.checkedListBox_MultiplayerOptions.TabIndex = 1;
            this.checkedListBox_MultiplayerOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_MultiplayerOptions_ItemCheck);
            // 
            // panel_GameConfigStatus
            // 
            this.panel_GameConfigStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_GameConfigStatus.Controls.Add(this.label_GameConfigNameStatus);
            this.panel_GameConfigStatus.Location = new System.Drawing.Point(6, 493);
            this.panel_GameConfigStatus.Margin = new System.Windows.Forms.Padding(2);
            this.panel_GameConfigStatus.Name = "panel_GameConfigStatus";
            this.panel_GameConfigStatus.Size = new System.Drawing.Size(231, 60);
            this.panel_GameConfigStatus.TabIndex = 6;
            // 
            // label_GameConfigNameStatus
            // 
            this.label_GameConfigNameStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_GameConfigNameStatus.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_GameConfigNameStatus.ForeColor = System.Drawing.Color.Red;
            this.label_GameConfigNameStatus.Location = new System.Drawing.Point(0, 0);
            this.label_GameConfigNameStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_GameConfigNameStatus.Name = "label_GameConfigNameStatus";
            this.label_GameConfigNameStatus.Size = new System.Drawing.Size(229, 58);
            this.label_GameConfigNameStatus.TabIndex = 0;
            this.label_GameConfigNameStatus.Text = "CONFIGURATION NOT FOUND";
            this.label_GameConfigNameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 553);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(989, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "All changes are saved automatically.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilityToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.extendedConfigurationToolStripMenuItem,
            this.writeOptimalConfigurationToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // extendedConfigurationToolStripMenuItem
            // 
            this.extendedConfigurationToolStripMenuItem.Name = "extendedConfigurationToolStripMenuItem";
            this.extendedConfigurationToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.extendedConfigurationToolStripMenuItem.Text = "Additional Options";
            this.extendedConfigurationToolStripMenuItem.Click += new System.EventHandler(this.ExtendedConfigurationToolStripMenuItem_Click);
            // 
            // writeOptimalConfigurationToolStripMenuItem
            // 
            this.writeOptimalConfigurationToolStripMenuItem.Name = "writeOptimalConfigurationToolStripMenuItem";
            this.writeOptimalConfigurationToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.writeOptimalConfigurationToolStripMenuItem.Text = "Write Optimal Configuration";
            this.writeOptimalConfigurationToolStripMenuItem.Click += new System.EventHandler(this.WriteOptimalConfigurationToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkToolStripMenuItem,
            this.createToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // openFileDialog_SelectGameConfig
            // 
            this.openFileDialog_SelectGameConfig.DefaultExt = "ini";
            this.openFileDialog_SelectGameConfig.FileName = "Baldur.lua";
            this.openFileDialog_SelectGameConfig.Filter = "Lua Files|*.lua";
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 592);
            this.Controls.Add(this.panel_Content);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfigWindow";
            this.Load += new System.EventHandler(this.ConfigWindow_Load);
            this.panel_GraphicOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_Content.ResumeLayout(false);
            this.panel_Content.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_GameConfigStatus.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox_GraphicOptions;
        private Panel panel_GraphicOptions;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private HScrollBar hScrollBar_GameSpeed;
        private Label label_SpeedValueDisplay;
        private Panel panel4;
        private CheckedListBox checkedListBox_ProgramOptionsTwo;
        private Label label8;
        private CheckedListBox checkedListBox_ProgramOptionsOne;
        private Panel panel_Content;
        private Label label3;
        private Panel panel_GameConfigStatus;
        private Label label_GameConfigNameStatus;
        private Panel panel3;
        private Label label9;
        private CheckedListBox checkedListBox_MultiplayerOptions;
        private CheckedListBox checkedListBox_ProgramOptionsThree;
        private Panel panel6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem utilityToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem extendedConfigurationToolStripMenuItem;
        private ToolStripMenuItem writeOptimalConfigurationToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem checkToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem restoreToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private Panel panel2;
        private Label label4;
        private CheckedListBox checkedListBox_ExtendedProgramConfigurationOne;
        private CheckedListBox checkedListBox_ExtendedProgramConfigurationTwo;
        private CheckedListBox checkedListBox_ExtendedProgramConfigurationThree;
        private OpenFileDialog openFileDialog_SelectGameConfig;
    }
}