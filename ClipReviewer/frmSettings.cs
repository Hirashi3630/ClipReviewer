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
            if (e.Node != null && !string.IsNullOrEmpty(e.Node.Text))
                tabControler.SelectTab("tab" + e.Node?.Text);
        }

        #endregion

        #region Settings
        #region TabGeneral

        #endregion
        #endregion

        

        
    }
}
