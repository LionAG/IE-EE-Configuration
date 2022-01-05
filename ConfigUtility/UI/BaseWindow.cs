namespace ConfigUtility.UI
{
    public class BaseWindow : Form
    {
        // Parameterless constructor is necessary for designer instance
        public BaseWindow()
        {
            InitializeComponent();
            InitializeWindow();
        }

        protected void InitializeWindow()
        {
            this.Text = "Baldur's Gate Configuration";
            this.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            this.Icon = Properties.Resources.config_gear_icon;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseWindow
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "BaseWindow";
            this.Load += new System.EventHandler(this.BaseWindow_Load);
            this.ResumeLayout(false);

        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
