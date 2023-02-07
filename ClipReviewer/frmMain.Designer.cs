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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnStartReview = new System.Windows.Forms.Button();
            this.pBoxLeft = new System.Windows.Forms.Panel();
            this.compClipsCategories1 = new ClipReviewer.compClipsCategories();
            this.pBoxRight = new System.Windows.Forms.Panel();
            this.compClipsData1 = new ClipReviewer.Controls.compClipsData();
            this.btnClipDataLoad = new System.Windows.Forms.Button();
            this.pBoxLeft.SuspendLayout();
            this.pBoxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxClipsFolderLocation
            // 
            this.txtBoxClipsFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxClipsFolderLocation.Location = new System.Drawing.Point(90, 5);
            this.txtBoxClipsFolderLocation.Name = "txtBoxClipsFolderLocation";
            this.txtBoxClipsFolderLocation.Size = new System.Drawing.Size(591, 23);
            this.txtBoxClipsFolderLocation.TabIndex = 0;
            this.txtBoxClipsFolderLocation.TextChanged += new System.EventHandler(this.txtBoxClipsFolderLocation_TextChanged);
            // 
            // btnClipsFolderBrowse
            // 
            this.btnClipsFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipsFolderBrowse.Location = new System.Drawing.Point(687, 5);
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
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clips Folder:";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(855, 33);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 469);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(855, 62);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // btnStartReview
            // 
            this.btnStartReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartReview.Location = new System.Drawing.Point(770, 476);
            this.btnStartReview.Name = "btnStartReview";
            this.btnStartReview.Size = new System.Drawing.Size(73, 50);
            this.btnStartReview.TabIndex = 7;
            this.btnStartReview.Text = "Start Reviewing";
            this.btnStartReview.UseVisualStyleBackColor = true;
            this.btnStartReview.Click += new System.EventHandler(this.btnStartReview_Click);
            // 
            // pBoxLeft
            // 
            this.pBoxLeft.Controls.Add(this.compClipsCategories1);
            this.pBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBoxLeft.Location = new System.Drawing.Point(0, 33);
            this.pBoxLeft.Name = "pBoxLeft";
            this.pBoxLeft.Size = new System.Drawing.Size(427, 436);
            this.pBoxLeft.TabIndex = 9;
            // 
            // compClipsCategories1
            // 
            this.compClipsCategories1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compClipsCategories1.Location = new System.Drawing.Point(0, 0);
            this.compClipsCategories1.Name = "compClipsCategories1";
            this.compClipsCategories1.Size = new System.Drawing.Size(427, 436);
            this.compClipsCategories1.TabIndex = 0;
            // 
            // pBoxRight
            // 
            this.pBoxRight.Controls.Add(this.compClipsData1);
            this.pBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBoxRight.Location = new System.Drawing.Point(427, 33);
            this.pBoxRight.Name = "pBoxRight";
            this.pBoxRight.Size = new System.Drawing.Size(428, 436);
            this.pBoxRight.TabIndex = 10;
            // 
            // compClipsData1
            // 
            this.compClipsData1.Clips = null;
            this.compClipsData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compClipsData1.Location = new System.Drawing.Point(0, 0);
            this.compClipsData1.LockedSelection = -1;
            this.compClipsData1.Name = "compClipsData1";
            this.compClipsData1.Size = new System.Drawing.Size(428, 436);
            this.compClipsData1.TabIndex = 0;
            // 
            // btnClipDataLoad
            // 
            this.btnClipDataLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipDataLoad.Location = new System.Drawing.Point(768, 5);
            this.btnClipDataLoad.Name = "btnClipDataLoad";
            this.btnClipDataLoad.Size = new System.Drawing.Size(75, 23);
            this.btnClipDataLoad.TabIndex = 0;
            this.btnClipDataLoad.Text = "Load";
            this.btnClipDataLoad.UseVisualStyleBackColor = true;
            this.btnClipDataLoad.Click += new System.EventHandler(this.btnClipDataLoad_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(855, 531);
            this.Controls.Add(this.btnClipDataLoad);
            this.Controls.Add(this.pBoxRight);
            this.Controls.Add(this.pBoxLeft);
            this.Controls.Add(this.btnStartReview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClipsFolderBrowse);
            this.Controls.Add(this.txtBoxClipsFolderLocation);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitter2);
            this.MinimumSize = new System.Drawing.Size(500, 330);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pBoxLeft.ResumeLayout(false);
            this.pBoxRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxClipsFolderLocation;
        private Button btnClipsFolderBrowse;
        private Label label1;
        private FolderBrowserDialog clipsFolderDialog;
        private Splitter splitter1;
        private Splitter splitter2;
        private Button btnStartReview;
        private Panel pBoxLeft;
        private Panel pBoxRight;
        private compClipsCategories compClipsCategories1;
        private Button btnClipDataLoad;
        private Controls.compClipsData compClipsData1;
    }
}