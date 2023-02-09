namespace ClipReviewer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnStartReview = new System.Windows.Forms.Button();
            this.compClipsCategories1 = new ClipReviewer.compClipsCategories();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compClipsData1 = new ClipReviewer.Controls.compClipsData();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 469);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(858, 62);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // btnStartReview
            // 
            this.btnStartReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartReview.Location = new System.Drawing.Point(782, 475);
            this.btnStartReview.Name = "btnStartReview";
            this.btnStartReview.Size = new System.Drawing.Size(73, 50);
            this.btnStartReview.TabIndex = 7;
            this.btnStartReview.Text = "Start Reviewing";
            this.btnStartReview.UseVisualStyleBackColor = true;
            this.btnStartReview.Click += new System.EventHandler(this.btnStartReview_Click);
            // 
            // compClipsCategories1
            // 
            this.compClipsCategories1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compClipsCategories1.Location = new System.Drawing.Point(0, 10);
            this.compClipsCategories1.Name = "compClipsCategories1";
            this.compClipsCategories1.Size = new System.Drawing.Size(429, 435);
            this.compClipsCategories1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "topMenuStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubWikiToolStripMenuItem,
            this.reportIssueToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // githubWikiToolStripMenuItem
            // 
            this.githubWikiToolStripMenuItem.Name = "githubWikiToolStripMenuItem";
            this.githubWikiToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.githubWikiToolStripMenuItem.Text = "Wiki";
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.reportIssueToolStripMenuItem.Text = "Report Issue";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // compClipsData1
            // 
            this.compClipsData1.Clips = null;
            this.compClipsData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compClipsData1.Location = new System.Drawing.Point(0, 10);
            this.compClipsData1.LockedSelection = -1;
            this.compClipsData1.Name = "compClipsData1";
            this.compClipsData1.Size = new System.Drawing.Size(425, 435);
            this.compClipsData1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.compClipsCategories1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.compClipsData1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(858, 445);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(858, 531);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnStartReview);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 330);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Splitter splitter2;
        private Button btnStartReview;
        private compClipsCategories compClipsCategories1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem githubWikiToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Controls.compClipsData compClipsData1;
        private SplitContainer splitContainer1;
        private ToolStripMenuItem reportIssueToolStripMenuItem;
    }
}