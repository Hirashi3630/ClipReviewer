using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;

namespace ClipReviewer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            RefreshUI();
            FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official);
        }

        private void RefreshUI(object sender = default, EventArgs e = default)
        {
            // clips folder location
            bool isValid = IsPathValid(txtBoxClipsFolderLocation.Text) && Directory.Exists(txtBoxClipsFolderLocation.Text);
            txtBoxClipsFolderLocation.BackColor =
                isValid || string.IsNullOrEmpty(txtBoxClipsFolderLocation.Text)
                ? Color.White : Color.MistyRose;
            btnClipDataLoad.Enabled = isValid;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            pBoxLeft.Width = Convert.ToInt32(this.Width * .5 - 10);
            pBoxRight.Width = Convert.ToInt32(this.Width * .5 - 10);
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            compClipsCategories1.Unselect();
        }

        private void btnClipsFolderBrowse_Click(object sender, EventArgs e)
        {
            if (clipsFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxClipsFolderLocation.Text = clipsFolderDialog.SelectedPath;
            }
        }

        private static bool IsPathValid(string path)
            => new Regex("^(?:[a-zA-Z]:|\\\\\\\\[\\w\\.]+\\\\[\\w.$]+)\\\\(?:[\\w\\s]+\\\\)*[\\w\\s]+$").IsMatch(path);

        private async void btnClipDataLoad_Click(object sender, EventArgs e)
        {
            //// load clips to datagrid
            //dataGridView1.
            await compClipsData1.LoadClips(txtBoxClipsFolderLocation.Text);
        }

        private void btnStartReview_Click(object sender, EventArgs e)
        {
            compClipsData1.LockedSelection++;
            Console.WriteLine(compClipsData1.LockedSelection);
        }
    }
}
