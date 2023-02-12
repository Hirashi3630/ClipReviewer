using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipReviewer.Utils
{
    public static class MsgBox
    {
        public static DialogResult Info(string msg, string title = "Info", MessageBoxButtons buttons = MessageBoxButtons.OK)
            => MessageBox.Show(msg, title, buttons, MessageBoxIcon.Information);
        public static DialogResult Error(string msg, string title = "Error", MessageBoxButtons buttons = MessageBoxButtons.OK)
             => MessageBox.Show(msg, title, buttons, MessageBoxIcon.Error);
        public static DialogResult Warning(string msg, string title = "Warning", MessageBoxButtons buttons = MessageBoxButtons.OKCancel)
            => MessageBox.Show(msg, title, buttons, MessageBoxIcon.Warning);
        public static DialogResult Question(string msg, string title = "Confirmation", MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel)
            => MessageBox.Show(msg, title, buttons, MessageBoxIcon.Question);
    }
}
