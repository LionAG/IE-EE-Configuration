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
