using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipReviewer
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            // this guy is a live saver https://stackoverflow.com/a/10346520/10806542 
            tabControler.Appearance = TabAppearance.FlatButtons;
            tabControler.ItemSize = new Size(0, 1);
            tabControler.SizeMode = TabSizeMode.Fixed;

            // change parents from main enable checkboxes for groupboxes
            gBoxClipReviewAutoSeek.Controls.Remove(cBoxClipReviewAutoSeekEnabled);
            pClipReviewAutoSeek.Controls.Add(cBoxClipReviewAutoSeekEnabled);
            cBoxClipReviewAutoSeekEnabled.BringToFront();

            LoadSettings();
            RefreshUI(null, null);
        }

        private void LoadSettings()
        {
            // TODO: load settings
        }

        private void RefreshUI(object sender, EventArgs e)
        {
            gBoxClipReviewAutoSeek.Enabled = cBoxClipReviewAutoSeekEnabled.Checked;
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

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

    }
}
