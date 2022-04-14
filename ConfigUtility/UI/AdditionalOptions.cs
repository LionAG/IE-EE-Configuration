using ConfigUtility.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigUtility.UI
{
    public partial class AdditionalOptions : BaseWindow
    {
        private BaldurPropertyManager BaldurPropertyManager;

        public AdditionalOptions(BaldurPropertyManager baldurPropertyManager)
        {
            InitializeComponent();
            this.BaldurPropertyManager = baldurPropertyManager;
        }

        private void AdditionalOptions_Load(object sender, EventArgs e)
        {
            
        }
    }
}
