using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;

namespace ConfigUtility.UI
{
    public class Msg
    {
        public static DialogResult Information(string msg, string header = "Information")
        {
            return MessageBox.Show(msg, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult Error(string msg, string header = "Error")
        {
            return MessageBox.Show(msg, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Exception(string msg, string header = "Exception")
        {
            return MessageBox.Show(msg, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Warning(string msg, string header = "Warning")
        {
            return MessageBox.Show(msg, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ToastInformation(string msg, int ExpirationSec = 10)
        {
            new ToastContentBuilder().AddCustomTimeStamp(DateTime.Now)
                                     .AddText(msg)
                                     .Show(t => 
                                     {
                                         Random r = new();

                                         t.Tag = r.NextInt64().ToString();
                                         t.Dismissed += Dismissed;
                                         t.ExpirationTime = DateTime.Now.AddSeconds(ExpirationSec); 
                                     });
        }

        private static void Dismissed(ToastNotification sender, ToastDismissedEventArgs args)
        {
            ToastNotificationManagerCompat.History.Remove(sender.Tag);
        }
    }
}
