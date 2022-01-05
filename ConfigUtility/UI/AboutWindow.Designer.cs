namespace ConfigUtility.UI
{
    partial class AboutWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAboutContent = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAboutHeader = new System.Windows.Forms.Panel();
            this.roundPictureBox1 = new ConfigUtility.UI.Controls.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAboutContent.SuspendLayout();
            this.panelText.SuspendLayout();
            this.panelAboutHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelAboutContent);
            this.panel1.Controls.Add(this.panelAboutHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 388);
            this.panel1.TabIndex = 0;
            // 
            // panelAboutContent
            // 
            this.panelAboutContent.Controls.Add(this.panelText);
            this.panelAboutContent.Controls.Add(this.label4);
            this.panelAboutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAboutContent.Location = new System.Drawing.Point(0, 148);
            this.panelAboutContent.Name = "panelAboutContent";
            this.panelAboutContent.Size = new System.Drawing.Size(695, 240);
            this.panelAboutContent.TabIndex = 4;
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.label2);
            this.panelText.Controls.Add(this.label3);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(695, 188);
            this.panelText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(695, 137);
            this.label2.TabIndex = 0;
            this.label2.Text = "This is an unofficial configuration utility for IE:EE games.\r\nAllows for changing" +
    " many of the properties changeable through the Baldur.lua file.\r\n\r\nIcons provide" +
    "d by pixabay.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(695, 51);
            this.label3.TabIndex = 1;
            this.label3.Text = "Created by silver_eagle.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(695, 63);
            this.label4.TabIndex = 2;
            this.label4.Text = "Special thanks to: CamDawg, skellytz, Bubb && Sam. for help during development.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAboutHeader
            // 
            this.panelAboutHeader.Controls.Add(this.roundPictureBox1);
            this.panelAboutHeader.Controls.Add(this.label1);
            this.panelAboutHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAboutHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAboutHeader.Name = "panelAboutHeader";
            this.panelAboutHeader.Size = new System.Drawing.Size(695, 148);
            this.panelAboutHeader.TabIndex = 3;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.Color.White;
            this.roundPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundPictureBox1.Image = global::ConfigUtility.Properties.Resources.config_gear;
            this.roundPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(146, 148);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundPictureBox1.TabIndex = 1;
            this.roundPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 148);
            this.label1.TabIndex = 2;
            this.label1.Text = "Infinity Engine - Enhanced Edition Configuration Utility";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.Font = new System.Drawing.Font("Cascadia Mono", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_Version.Location = new System.Drawing.Point(658, 396);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(56, 18);
            this.label_Version.TabIndex = 3;
            this.label_Version.Text = "v1.0.0";
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 422);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.Padding = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panelAboutContent.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelAboutHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Controls.RoundPictureBox roundPictureBox1;
        private Panel panelAboutContent;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panelAboutHeader;
        private Label label1;
        private Panel panelText;
        private Label label_Version;
    }
}
