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
            this.txtBoxClipsFolderLocation = new System.Windows.Forms.TextBox();
            this.btnClipsFolderBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clipsFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnStartReview = new System.Windows.Forms.Button();
            this.compClipsCategories1 = new ClipReviewer.compClipsCategories();
            this.btnClipDataLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compClipsData1 = new ClipReviewer.Controls.compClipsData();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxClipsFolderLocation
            // 
            this.txtBoxClipsFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxClipsFolderLocation.Location = new System.Drawing.Point(88, 7);
            this.txtBoxClipsFolderLocation.Name = "txtBoxClipsFolderLocation";
            this.txtBoxClipsFolderLocation.Size = new System.Drawing.Size(172, 23);
            this.txtBoxClipsFolderLocation.TabIndex = 0;
            this.txtBoxClipsFolderLocation.TextChanged += new System.EventHandler(this.txtBoxClipsFolderLocation_TextChanged);
            // 
            // btnClipsFolderBrowse
            // 
            this.btnClipsFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipsFolderBrowse.Location = new System.Drawing.Point(266, 7);
            this.btnClipsFolderBrowse.Name = "btnClipsFolderBrowse";
            this.btnClipsFolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnClipsFolderBrowse.TabIndex = 1;
            this.btnClipsFolderBrowse.Text = "Browse";
            this.btnClipsFolderBrowse.UseVisualStyleBackColor = true;
            this.btnClipsFolderBrowse.Click += new System.EventHandler(this.btnClipsFolderBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clips Folder:";
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
            // btnClipDataLoad
            // 
            this.btnClipDataLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipDataLoad.Location = new System.Drawing.Point(347, 7);
            this.btnClipDataLoad.Name = "btnClipDataLoad";
            this.btnClipDataLoad.Size = new System.Drawing.Size(75, 23);
            this.btnClipDataLoad.TabIndex = 0;
            this.btnClipDataLoad.Text = "Load";
            this.btnClipDataLoad.UseVisualStyleBackColor = true;
            this.btnClipDataLoad.Click += new System.EventHandler(this.btnClipDataLoad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxClipsFolderLocation);
            this.panel1.Controls.Add(this.btnClipDataLoad);
            this.panel1.Controls.Add(this.btnClipsFolderBrowse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 33);
            this.panel1.TabIndex = 11;
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
            this.githubWikiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.githubWikiToolStripMenuItem.Text = "Wiki";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // compClipsData1
            // 
            this.compClipsData1.Clips = null;
            this.compClipsData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compClipsData1.Location = new System.Drawing.Point(0, 0);
            this.compClipsData1.LockedSelection = -1;
            this.compClipsData1.Name = "compClipsData1";
            this.compClipsData1.Size = new System.Drawing.Size(425, 398);
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(858, 445);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 10);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.compClipsData1);
            this.splitContainer2.Size = new System.Drawing.Size(425, 435);
            this.splitContainer2.SplitterDistance = 33;
            this.splitContainer2.TabIndex = 1;
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.reportIssueToolStripMenuItem.Text = "Report Issue";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxClipsFolderLocation;
        private Button btnClipsFolderBrowse;
        private Label label1;
        private FolderBrowserDialog clipsFolderDialog;
        private Splitter splitter2;
        private Button btnStartReview;
        private compClipsCategories compClipsCategories1;
        private Button btnClipDataLoad;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem githubWikiToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Controls.compClipsData compClipsData1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ToolStripMenuItem reportIssueToolStripMenuItem;
    }
}