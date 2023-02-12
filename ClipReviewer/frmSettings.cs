using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClipReviewer
{
    public partial class frmSettings : Form
    {
        private static readonly string CUSTOM_TIME_TT_TEXT =
            "Time that you want to automatically seek to\r\n" +
            "Use '%' at the end if you want to use percentages\r\n" +
            "Use 's' at the end if you want to use seconds\r\n" +
            "Usage: '3000' or '50%' or '3s'\r\n" +
            "Default is in miliseconds\r\n";

        public frmSettings()
        {
            InitializeComponent();
            // this guy is a live saver https://stackoverflow.com/a/10346520/10806542 
            tabControler.Appearance = TabAppearance.FlatButtons;
            tabControler.ItemSize = new Size(0, 1);
            tabControler.SizeMode = TabSizeMode.Fixed;

            // change parents from main enable checkboxes for groupboxes
            gBoxAutoSeek.Controls.Remove(cBoxAutoSeekEnabled);
            pAutoSeek.Controls.Add(cBoxAutoSeekEnabled);
            cBoxAutoSeekEnabled.BringToFront();
            gBoxThumbnailGenerator.Controls.Remove(cBoxThumbnailGenerator);
            pThumbnailGenerator.Controls.Add(cBoxThumbnailGenerator);
            cBoxThumbnailGenerator.BringToFront();

            LoadSettings();
            RefreshUI(null, null);
        }

        private void LoadSettings()
        {
            // TODO: load settings
        }

        private void RefreshUI(object sender, EventArgs e)
        {
            gBoxAutoSeek.Enabled = cBoxAutoSeekEnabled.Checked;
            gBoxThumbnailGenerator.Enabled = cBoxThumbnailGenerator.Checked;
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // TODO: save settings
        }

        #region Search

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: add search function
        }

        private void treeViewSearch_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && !string.IsNullOrEmpty(e.Node.Name))
                tabControler.SelectTab("tab" + e.Node?.Name);
        }



        #endregion

        #region Settings
        #region TabGeneral

        #endregion

        #endregion

        #region Tooltips
        private void ShowTT(string text, IWin32Window control)
        {
            Console.WriteLine("ennter");
            tt = new System.Windows.Forms.ToolTip();
            tt.InitialDelay = 0;
            tt.UseAnimation= false;
            tt.Show(string.Empty, control);
            tt.Show(text, control, 0);
        }

        private void HideTT(object sender, EventArgs e)
        {
            if (tt != null)
                tt.Dispose();
        }

        #endregion

        private void txtBoxAutoSeekTime_MouseEnter(object sender, EventArgs e)
        {
            ShowTT(CUSTOM_TIME_TT_TEXT, txtBoxAutoSeekTime);
        }
        private void txtBoxThumbnailGeneratorTime_MouseEnter(object sender, EventArgs e)
        {
            ShowTT(CUSTOM_TIME_TT_TEXT, txtBoxThumbnailGeneratorTime);
        }
    }
}
