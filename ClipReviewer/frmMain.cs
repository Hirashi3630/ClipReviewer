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
            DownloadFFmpeg();
            this.Text = $"{compAbout.AssemblyTitle} • {compAbout.AssemblyVersion}";
#if DEBUG
            this.Text += " DEBUG";
#endif
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

        private void frmMain_Click(object sender, EventArgs e)
        {
            compClipsCategories1.Unselect();
        }

        private void btnStartReview_Click(object sender, EventArgs e)
        {
            compClipsData1.LockedSelection++;
            Console.WriteLine(compClipsData1.LockedSelection);
        }
    }
}
