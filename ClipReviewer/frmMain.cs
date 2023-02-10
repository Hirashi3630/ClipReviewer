using ClipReviewer.Controls;
using ClipReviewer.Properties;
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
            compClipsData1.LockedSelection++;
            Console.WriteLine(compClipsData1.LockedSelection);
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
            compAbout.OpenURL(Resources.GithubURL);
        }

        private void reportIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compAbout.OpenURL(Resources.GithubURL, "issues");
        }

        private void checkUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: check for updates
            compAbout.OpenURL(Resources.GithubURL, "releases");
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
