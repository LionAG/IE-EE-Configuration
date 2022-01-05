using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.label_Version.Text = $"v{AssemblyVersion}";
        }
    }
}
