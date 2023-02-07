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
        private bool isClipFolderValid =>
            IsPathValid(txtBoxClipsFolderLocation.Text) && Directory.Exists(txtBoxClipsFolderLocation.Text);

        public frmMain()
        {
            InitializeComponent();
            RefreshUI();
            frmMain_Resize(null, null);
            DownloadFFmpeg();
        }

        private void DownloadFFmpeg()
        {
            string ffmpegDir = Path.Combine(AppContext.BaseDirectory, "FFmpeg");
            if (!Directory.Exists(ffmpegDir))
                Directory.CreateDirectory(ffmpegDir);
            if (!File.Exists(Path.Combine(ffmpegDir,"ffmpeg.exe")))
                FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full, ffmpegDir, null);
            FFmpeg.SetExecutablesPath(ffmpegDir);
        }

        private void RefreshUI(object sender = default, EventArgs e = default)
        {
            // clips folder location
            var isValid = isClipFolderValid;
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

        private void txtBoxClipsFolderLocation_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
            if (isClipFolderValid)
            {
                int clipsCount = compClipsData1.GetClipFiles(txtBoxClipsFolderLocation.Text).Count();
                btnClipDataLoad.Text = $"Load ({clipsCount})";
            }
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
