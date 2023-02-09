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
            this.btnStartReview = new System.Windows.Forms.Button();
            this.compClipsCategories1 = new ClipReviewer.compClipsCategories();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compClipsData1 = new ClipReviewer.Controls.compClipsData();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartReview
            // 
            this.btnStartReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartReview.Location = new System.Drawing.Point(676, 357);
            this.btnStartReview.Name = "btnStartReview";
            this.btnStartReview.Size = new System.Drawing.Size(81, 42);
            this.btnStartReview.TabIndex = 7;
            this.btnStartReview.Text = "Start &Reviewing";
            this.btnStartReview.UseVisualStyleBackColor = true;
            this.btnStartReview.Click += new System.EventHandler(this.btnStartReview_Click);
            // 
            // compClipsCategories1
            // 
            this.compClipsCategories1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compClipsCategories1.Location = new System.Drawing.Point(3, 10);
            this.compClipsCategories1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.compClipsCategories1.Name = "compClipsCategories1";
            this.compClipsCategories1.Size = new System.Drawing.Size(374, 333);
            this.compClipsCategories1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "topMenuStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubWikiToolStripMenuItem,
            this.reportIssueToolStripMenuItem,
            this.checkUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // githubWikiToolStripMenuItem
            // 
            this.githubWikiToolStripMenuItem.Name = "githubWikiToolStripMenuItem";
            this.githubWikiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.githubWikiToolStripMenuItem.Text = "Open &Wiki";
            this.githubWikiToolStripMenuItem.Click += new System.EventHandler(this.githubWikiToolStripMenuItem_Click);
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportIssueToolStripMenuItem.Text = "Report &Issue";
            this.reportIssueToolStripMenuItem.Click += new System.EventHandler(this.reportIssueToolStripMenuItem_Click);
            // 
            // checkUpdatesToolStripMenuItem
            // 
            this.checkUpdatesToolStripMenuItem.Name = "checkUpdatesToolStripMenuItem";
            this.checkUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkUpdatesToolStripMenuItem.Text = "Check for &Updates";
            this.checkUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // compClipsData1
            // 
            this.compClipsData1.Clips = null;
            this.compClipsData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compClipsData1.Location = new System.Drawing.Point(383, 10);
            this.compClipsData1.LockedSelection = -1;
            this.compClipsData1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.compClipsData1.Name = "compClipsData1";
            this.compClipsData1.Size = new System.Drawing.Size(374, 333);
            this.compClipsData1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.compClipsCategories1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStartReview, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.compClipsData1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 402);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(760, 426);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(720, 400);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnStartReview;
        private compClipsCategories compClipsCategories1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem githubWikiToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Controls.compClipsData compClipsData1;
        private ToolStripMenuItem reportIssueToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem checkUpdatesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}