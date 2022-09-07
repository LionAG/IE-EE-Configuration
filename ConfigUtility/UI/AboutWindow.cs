using System.Reflection;

namespace ConfigUtility.UI
{
    partial class AboutWindow : BaseWindow
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        #region Assembly Attribute Accessors

        public string AssemblyVersion
        {
            get
            {
                var AV = Assembly.GetExecutingAssembly().GetName().Version;
                return AV != null ? AV.ToString(3) : "No version info";
            }
        }

        #endregion

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            label_Version.Text = $"v{AssemblyVersion}";
        }
    }
}
