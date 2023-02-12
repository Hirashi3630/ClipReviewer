using ClipReviewer.Controls;
using ClipReviewer.Properties;
using ClipReviewer.Utils;
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

namespace ClipReviewer
{
    public partial class frmMain : Form
    {
        private bool m_ReviewInProgress = false;
        public bool ReviewInProgress
        {
            get => m_ReviewInProgress;
            set
            {
                m_ReviewInProgress = value;

                btnStartReview.Text = $"{(value ? "Stop" : "Start")} &Reviewing";
                compClipsCategories1.ReviewInProgress = value;
                compClipsData1.ReviewInProgress = value;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            this.Text = $"{compAbout.AssemblyTitle} • {compAbout.AssemblyVersion}";
#if DEBUG
            this.Text += " DEBUG";
#endif
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            compClipsCategories1.Unselect();
        }

        private void btnStartReview_Click(object sender, EventArgs e)
        {
            if (compClipsData1.Clips == null || compClipsData1.Clips.Count <= 0)
            {
                MsgBox.Error("You can not start reviewing without loading clips!");
                return;
            }
            compClipsData1.LockedSelection = 0;
            ReviewInProgress = !ReviewInProgress;
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
