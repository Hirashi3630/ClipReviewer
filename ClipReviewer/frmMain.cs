using ClipReviewer.Controls;
using ClipReviewer.MediaControllers;
using ClipReviewer.Properties;
using ClipReviewer.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;
using static System.Windows.Forms.AxHost;

namespace ClipReviewer
{
    public partial class frmMain : Form
    {
        public static Reviewer MainReviewer { get; set; }

        public frmMain()
        {
            // TODO: add autodetect or/and add option to change it in settings
            MainReviewer = new Reviewer(new List<Clip>(), new VLCController()); 

            InitializeComponent();
            this.Text = $"{compAbout.AssemblyTitle} • {compAbout.AssemblyVersion}";
#if DEBUG
            this.Text += " DEBUG";
#endif
            RefreshUI(null, null);
            MainReviewer.OnReviewStateChanged += (_, _) => RefreshUI(null, null);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainReviewer != null)
                MainReviewer.Dispose();
        }

        private void RefreshUI(object sender, EventArgs e)
        {
            // refresh lblState
            lblCurrentState.Text = "Current State: " + MainReviewer.State.ToString();

            // refresh btnStart
            switch (MainReviewer.State)
            {
                case ReviewerState.Stopped:
                    btnStartReview.Text = "Start";
                    btnPauseReview.Enabled = false;
                    break;
                case ReviewerState.Reviewing:
                    btnStartReview.Text = "Stop";
                    btnPauseReview.Text = "Pause";
                    btnPauseReview.Enabled = true;
                    break;
                case ReviewerState.Paused:
                    btnStartReview.Text = "Stop";
                    btnPauseReview.Text = "Continue";
                    btnPauseReview.Enabled = true;
                    break;
                case ReviewerState.Unknown:
                default:
                    Console.WriteLine("ReviwerState is unknown!");
                    break;
            }
        }

        private void compClipsCategories1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            compClipsCategories1.Unselect();
        }

        private void btnStartReview_Click(object sender, EventArgs e)
        {
            if (MainReviewer.Clips == null || MainReviewer.Clips.Count <= 0)
            {
                MsgBox.Error("You can not start reviewing without loading clips!");
                return;
            }

            if (MainReviewer.State == ReviewerState.Stopped)
            {
                // Its stopped -> run it
                MainReviewer.State = ReviewerState.Reviewing;
                MainReviewer.Select(0);
            }
            else // Its running/paused -> stop it (reset it)
                MainReviewer.State = ReviewerState.Stopped;
        }

        private void btnPauseReview_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Pausing...");
            Console.WriteLine(MainReviewer.State);
            if (MainReviewer.State == ReviewerState.Reviewing) // Its paused -> continue
                MainReviewer.State = ReviewerState.Paused;
            else if (MainReviewer.State == ReviewerState.Paused) // Its running -> pause it
                MainReviewer.State = ReviewerState.Reviewing;
        }

        private void btnCommitReview_Click(object sender, EventArgs e)
        {

        }

        #region Menu
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmSettings a = new frmSettings())
                a.ShowDialog();
        }

        #region Menu - Help
        private void githubWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compAbout.OpenURL(compAbout.GITHUB_URL);
        }

        private void reportIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compAbout.OpenURL(compAbout.GITHUB_URL, "issues");
        }

        private void checkUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: check for updates
            compAbout.OpenURL(compAbout.GITHUB_URL, "releases");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (compAbout a = new compAbout())
                a.ShowDialog();
        }
        #endregion

        #endregion
    }
}
