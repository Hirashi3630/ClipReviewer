using ClipReviewer.Properties;
using ClipReviewer.Utils;
using System.Text.RegularExpressions;

namespace ClipReviewer
{
    public partial class frmSettings : Form
    {
        private static readonly string CUSTOM_TIME_TT_TEXT =
            "Time that you want to automatically seek to\r\n" +
            "Use '%' at the end if you want to use percentages\r\n" +
            "Don't use postfix if you want to use miliseconds\r\n" +
            "Usage: '3000' or '50%'\r\n";
        private static readonly string CUSTOM_TIME_VALIDATION_REGEX = @"^\d+(\.\d+)?%?$";
        private static readonly string GENERIC_ERROR_MSG = "Value is not valid!";

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
            gBoxThumbnailGenerator.Controls.Remove(cBoxThumbnailGeneratorEnabled);
            pThumbnailGenerator.Controls.Add(cBoxThumbnailGeneratorEnabled);
            cBoxThumbnailGeneratorEnabled.BringToFront();

            LoadSettings();
            RefreshUI(null, null);
        }

        private void RefreshUI(object sender, EventArgs e)
        {
            gBoxAutoSeek.Enabled = cBoxAutoSeekEnabled.Checked;
            gBoxThumbnailGenerator.Enabled = cBoxThumbnailGeneratorEnabled.Checked;
        }

        private void LoadSettings()
        {
            cBoxTopMostWhileReviewing.Checked = Settings.Default.TopMostWhileReviewing;
            cBoxAutoSeekEnabled.Checked = Settings.Default.AutoSeekEnabled;
            txtBoxAutoSeekTime.Text = Settings.Default.AutoSeekTime;
            cBoxThumbnailGeneratorEnabled.Checked = Settings.Default.ThumbGenEnabled;
            txtBoxThumbGenTime.Text = Settings.Default.ThumbGenTime;
            cBoxThumbGenIgnoreWarning.Checked = Settings.Default.ThumbGenIgnoreWarning;
            cBoxThumbGenUseCached.Checked = Settings.Default.ThumbGenUseCached;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!ValidateSettings())
            {
                // TODO: implement validation context + data source (example: https://www.youtube.com/watch?v=1zjIX2EtGQc)
                MsgBox.Error("Every setting needs to be valid!");
                return;
            }
            Settings.Default.TopMostWhileReviewing = cBoxTopMostWhileReviewing.Checked;
            Settings.Default.AutoSeekEnabled = cBoxAutoSeekEnabled.Checked;
            Settings.Default.AutoSeekTime = txtBoxAutoSeekTime.Text;
            Settings.Default.ThumbGenEnabled = cBoxThumbnailGeneratorEnabled.Checked;
            Settings.Default.ThumbGenTime = txtBoxThumbGenTime.Text;
            Settings.Default.ThumbGenIgnoreWarning = cBoxThumbGenIgnoreWarning.Checked;
            Settings.Default.ThumbGenUseCached = cBoxThumbGenUseCached.Checked;
            Settings.Default.Save();
            this.Close();
        }
        
        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private bool ValidateSettings()
        {
            return
                txtBoxAutoSeekTime_IsValid() &&
                txtBoxThumbnailGeneratorTime_IsValid();
        }
        #region TabGeneral

        #endregion

        #region TabClipLoader
        private void txtBoxAutoSeekTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            => errorProvider1.SetError(txtBoxAutoSeekTime, !txtBoxAutoSeekTime_IsValid() ? GENERIC_ERROR_MSG : "");
        private bool txtBoxAutoSeekTime_IsValid()
            => Regex.IsMatch(txtBoxAutoSeekTime.Text, CUSTOM_TIME_VALIDATION_REGEX);
        private void txtBoxThumbnailGeneratorTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            => errorProvider1.SetError(txtBoxThumbGenTime, !txtBoxThumbnailGeneratorTime_IsValid() ? GENERIC_ERROR_MSG : "");
        private bool txtBoxThumbnailGeneratorTime_IsValid()
            => Regex.IsMatch(txtBoxThumbGenTime.Text, CUSTOM_TIME_VALIDATION_REGEX);

        private void btnThumbGenClearCached_Click(object sender, EventArgs e)
        {
            var dir = Clip.THUMBNAIL_PATH;
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, true);
                MsgBox.Info("Deleted all cached thumbnails!");
            }
            else
                MsgBox.Info("No thumbnails were cached!");
        }
        #endregion
        #endregion

        #region Tooltips
        private void ShowTT(string text, IWin32Window control)
        {
            tt = new System.Windows.Forms.ToolTip();
            tt.InitialDelay = 0;
            tt.UseAnimation = false;
            tt.Show(string.Empty, control);
            tt.Show(text, control, 0);
        }

        private void HideTT(object sender, EventArgs e)
        {
            if (tt != null)
                tt.Dispose();
        }

        private void txtBoxAutoSeekTime_MouseEnter(object sender, EventArgs e)
        {
            ShowTT(CUSTOM_TIME_TT_TEXT, txtBoxAutoSeekTime);
        }
        private void txtBoxThumbnailGeneratorTime_MouseEnter(object sender, EventArgs e)
        {
            ShowTT(CUSTOM_TIME_TT_TEXT, txtBoxThumbGenTime);
        }

        #endregion

    }
}
