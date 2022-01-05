using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtility.UI
{
    internal class UITools
    {
        public static void ResetSelectedIndex(CheckedListBox checkedListBox)
        {
            // Avoid highlighting last used option
            checkedListBox.ClearSelected();
        }
    }
}
