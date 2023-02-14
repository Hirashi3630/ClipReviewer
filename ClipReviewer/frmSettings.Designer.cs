namespace ClipReviewer
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Clips");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Misc");
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.treeViewSearch = new System.Windows.Forms.TreeView();
            this.tabControler = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.gBoxGeneral = new System.Windows.Forms.GroupBox();
            this.flowLayoutGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.cBoxTopMostWhileReviewing = new System.Windows.Forms.CheckBox();
            this.tabClips = new System.Windows.Forms.TabPage();
            this.bBoxClips = new System.Windows.Forms.GroupBox();
            this.pThumbnailGenerator = new System.Windows.Forms.Panel();
            this.gBoxThumbnailGenerator = new System.Windows.Forms.GroupBox();
            this.btnThumbGenClearCached = new System.Windows.Forms.Button();
            this.cBoxThumbGenUseCached = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxThumbGenTime = new System.Windows.Forms.TextBox();
            this.cBoxThumbGenIgnoreWarning = new System.Windows.Forms.CheckBox();
            this.cBoxThumbnailGeneratorEnabled = new System.Windows.Forms.CheckBox();
            this.pAutoSeek = new System.Windows.Forms.Panel();
            this.gBoxAutoSeek = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAutoSeekTime = new System.Windows.Forms.TextBox();
            this.cBoxAutoSeekEnabled = new System.Windows.Forms.CheckBox();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.gBoxMisc = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiscardChanges = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutMain.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.tabControler.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gBoxGeneral.SuspendLayout();
            this.flowLayoutGeneral.SuspendLayout();
            this.tabClips.SuspendLayout();
            this.bBoxClips.SuspendLayout();
            this.pThumbnailGenerator.SuspendLayout();
            this.gBoxThumbnailGenerator.SuspendLayout();
            this.pAutoSeek.SuspendLayout();
            this.gBoxAutoSeek.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.pSearch, 0, 0);
            this.tableLayoutMain.Controls.Add(this.tabControler, 1, 0);
            this.tableLayoutMain.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutMain.Size = new System.Drawing.Size(704, 461);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.btnSearch);
            this.pSearch.Controls.Add(this.tBoxSearch);
            this.pSearch.Controls.Add(this.treeViewSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(10, 10);
            this.pSearch.Margin = new System.Windows.Forms.Padding(10);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(250, 412);
            this.pSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(189, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxSearch.Location = new System.Drawing.Point(0, 3);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.PlaceholderText = "This doesn\'t work yet";
            this.tBoxSearch.Size = new System.Drawing.Size(183, 23);
            this.tBoxSearch.TabIndex = 1;
            // 
            // treeViewSearch
            // 
            this.treeViewSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSearch.Location = new System.Drawing.Point(0, 32);
            this.treeViewSearch.Name = "treeViewSearch";
            treeNode1.Name = "General";
            treeNode1.Text = "General";
            treeNode2.Name = "Clips";
            treeNode2.Text = "Clips";
            treeNode3.Name = "Misc";
            treeNode3.Text = "Misc";
            this.treeViewSearch.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeViewSearch.Size = new System.Drawing.Size(250, 342);
            this.treeViewSearch.TabIndex = 0;
            this.treeViewSearch.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSearch_AfterSelect);
            // 
            // tabControler
            // 
            this.tabControler.Controls.Add(this.tabGeneral);
            this.tabControler.Controls.Add(this.tabClips);
            this.tabControler.Controls.Add(this.tabMisc);
            this.tabControler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControler.Location = new System.Drawing.Point(273, 3);
            this.tabControler.Multiline = true;
            this.tabControler.Name = "tabControler";
            this.tabControler.SelectedIndex = 0;
            this.tabControler.Size = new System.Drawing.Size(428, 426);
            this.tabControler.TabIndex = 2;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.gBoxGeneral);
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(420, 398);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // gBoxGeneral
            // 
            this.gBoxGeneral.Controls.Add(this.flowLayoutGeneral);
            this.gBoxGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxGeneral.Location = new System.Drawing.Point(3, 3);
            this.gBoxGeneral.Name = "gBoxGeneral";
            this.gBoxGeneral.Size = new System.Drawing.Size(414, 392);
            this.gBoxGeneral.TabIndex = 0;
            this.gBoxGeneral.TabStop = false;
            this.gBoxGeneral.Text = "General";
            // 
            // flowLayoutGeneral
            // 
            this.flowLayoutGeneral.Controls.Add(this.cBoxTopMostWhileReviewing);
            this.flowLayoutGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutGeneral.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutGeneral.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutGeneral.Name = "flowLayoutGeneral";
            this.flowLayoutGeneral.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.flowLayoutGeneral.Size = new System.Drawing.Size(408, 370);
            this.flowLayoutGeneral.TabIndex = 0;
            // 
            // cBoxTopMostWhileReviewing
            // 
            this.cBoxTopMostWhileReviewing.AutoSize = true;
            this.cBoxTopMostWhileReviewing.Location = new System.Drawing.Point(8, 5);
            this.cBoxTopMostWhileReviewing.Name = "cBoxTopMostWhileReviewing";
            this.cBoxTopMostWhileReviewing.Size = new System.Drawing.Size(273, 19);
            this.cBoxTopMostWhileReviewing.TabIndex = 0;
            this.cBoxTopMostWhileReviewing.Text = "Keep application pinned at top while reviewing";
            this.cBoxTopMostWhileReviewing.UseVisualStyleBackColor = true;
            // 
            // tabClips
            // 
            this.tabClips.Controls.Add(this.bBoxClips);
            this.tabClips.Location = new System.Drawing.Point(4, 24);
            this.tabClips.Name = "tabClips";
            this.tabClips.Padding = new System.Windows.Forms.Padding(3);
            this.tabClips.Size = new System.Drawing.Size(420, 398);
            this.tabClips.TabIndex = 2;
            this.tabClips.Text = "Clips";
            this.tabClips.UseVisualStyleBackColor = true;
            // 
            // bBoxClips
            // 
            this.bBoxClips.Controls.Add(this.pThumbnailGenerator);
            this.bBoxClips.Controls.Add(this.pAutoSeek);
            this.bBoxClips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBoxClips.Location = new System.Drawing.Point(3, 3);
            this.bBoxClips.Name = "bBoxClips";
            this.bBoxClips.Size = new System.Drawing.Size(414, 392);
            this.bBoxClips.TabIndex = 0;
            this.bBoxClips.TabStop = false;
            this.bBoxClips.Text = "Clips";
            // 
            // pThumbnailGenerator
            // 
            this.pThumbnailGenerator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pThumbnailGenerator.Controls.Add(this.gBoxThumbnailGenerator);
            this.pThumbnailGenerator.Location = new System.Drawing.Point(3, 148);
            this.pThumbnailGenerator.Name = "pThumbnailGenerator";
            this.pThumbnailGenerator.Size = new System.Drawing.Size(405, 115);
            this.pThumbnailGenerator.TabIndex = 0;
            // 
            // gBoxThumbnailGenerator
            // 
            this.gBoxThumbnailGenerator.Controls.Add(this.btnThumbGenClearCached);
            this.gBoxThumbnailGenerator.Controls.Add(this.cBoxThumbGenUseCached);
            this.gBoxThumbnailGenerator.Controls.Add(this.label2);
            this.gBoxThumbnailGenerator.Controls.Add(this.txtBoxThumbGenTime);
            this.gBoxThumbnailGenerator.Controls.Add(this.cBoxThumbGenIgnoreWarning);
            this.gBoxThumbnailGenerator.Controls.Add(this.cBoxThumbnailGeneratorEnabled);
            this.gBoxThumbnailGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxThumbnailGenerator.Location = new System.Drawing.Point(0, 0);
            this.gBoxThumbnailGenerator.Name = "gBoxThumbnailGenerator";
            this.gBoxThumbnailGenerator.Size = new System.Drawing.Size(405, 115);
            this.gBoxThumbnailGenerator.TabIndex = 3;
            this.gBoxThumbnailGenerator.TabStop = false;
            // 
            // btnThumbGenClearCached
            // 
            this.btnThumbGenClearCached.Location = new System.Drawing.Point(166, 76);
            this.btnThumbGenClearCached.Name = "btnThumbGenClearCached";
            this.btnThumbGenClearCached.Size = new System.Drawing.Size(152, 23);
            this.btnThumbGenClearCached.TabIndex = 5;
            this.btnThumbGenClearCached.Text = "Clear Cached Thumbnails";
            this.btnThumbGenClearCached.UseVisualStyleBackColor = true;
            this.btnThumbGenClearCached.Click += new System.EventHandler(this.btnThumbGenClearCached_Click);
            // 
            // cBoxThumbGenUseCached
            // 
            this.cBoxThumbGenUseCached.AutoSize = true;
            this.cBoxThumbGenUseCached.Location = new System.Drawing.Point(11, 79);
            this.cBoxThumbGenUseCached.Name = "cBoxThumbGenUseCached";
            this.cBoxThumbGenUseCached.Size = new System.Drawing.Size(149, 19);
            this.cBoxThumbGenUseCached.TabIndex = 4;
            this.cBoxThumbGenUseCached.Text = "Use cached thumbnails";
            this.cBoxThumbGenUseCached.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Snap at:";
            // 
            // txtBoxThumbGenTime
            // 
            this.txtBoxThumbGenTime.Location = new System.Drawing.Point(65, 25);
            this.txtBoxThumbGenTime.Name = "txtBoxThumbGenTime";
            this.txtBoxThumbGenTime.Size = new System.Drawing.Size(189, 23);
            this.txtBoxThumbGenTime.TabIndex = 3;
            this.txtBoxThumbGenTime.MouseEnter += new System.EventHandler(this.txtBoxThumbnailGeneratorTime_MouseEnter);
            this.txtBoxThumbGenTime.MouseLeave += new System.EventHandler(this.HideTT);
            this.txtBoxThumbGenTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxThumbnailGeneratorTime_Validating);
            // 
            // cBoxThumbGenIgnoreWarning
            // 
            this.cBoxThumbGenIgnoreWarning.AutoSize = true;
            this.cBoxThumbGenIgnoreWarning.Location = new System.Drawing.Point(11, 54);
            this.cBoxThumbGenIgnoreWarning.Name = "cBoxThumbGenIgnoreWarning";
            this.cBoxThumbGenIgnoreWarning.Size = new System.Drawing.Size(291, 19);
            this.cBoxThumbGenIgnoreWarning.TabIndex = 3;
            this.cBoxThumbGenIgnoreWarning.Text = "Ignore warning if value is higher then video length";
            this.cBoxThumbGenIgnoreWarning.UseVisualStyleBackColor = true;
            // 
            // cBoxThumbnailGeneratorEnabled
            // 
            this.cBoxThumbnailGeneratorEnabled.AutoSize = true;
            this.cBoxThumbnailGeneratorEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.cBoxThumbnailGeneratorEnabled.Location = new System.Drawing.Point(6, 0);
            this.cBoxThumbnailGeneratorEnabled.Name = "cBoxThumbnailGeneratorEnabled";
            this.cBoxThumbnailGeneratorEnabled.Size = new System.Drawing.Size(138, 19);
            this.cBoxThumbnailGeneratorEnabled.TabIndex = 0;
            this.cBoxThumbnailGeneratorEnabled.Text = "Thumbnail Generator";
            this.cBoxThumbnailGeneratorEnabled.UseVisualStyleBackColor = false;
            this.cBoxThumbnailGeneratorEnabled.CheckedChanged += new System.EventHandler(this.RefreshUI);
            // 
            // pAutoSeek
            // 
            this.pAutoSeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAutoSeek.Controls.Add(this.gBoxAutoSeek);
            this.pAutoSeek.Location = new System.Drawing.Point(3, 19);
            this.pAutoSeek.Margin = new System.Windows.Forms.Padding(0);
            this.pAutoSeek.Name = "pAutoSeek";
            this.pAutoSeek.Size = new System.Drawing.Size(405, 123);
            this.pAutoSeek.TabIndex = 2;
            // 
            // gBoxAutoSeek
            // 
            this.gBoxAutoSeek.Controls.Add(this.label1);
            this.gBoxAutoSeek.Controls.Add(this.txtBoxAutoSeekTime);
            this.gBoxAutoSeek.Controls.Add(this.cBoxAutoSeekEnabled);
            this.gBoxAutoSeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxAutoSeek.Location = new System.Drawing.Point(0, 0);
            this.gBoxAutoSeek.Name = "gBoxAutoSeek";
            this.gBoxAutoSeek.Size = new System.Drawing.Size(405, 123);
            this.gBoxAutoSeek.TabIndex = 1;
            this.gBoxAutoSeek.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seek to:";
            // 
            // txtBoxAutoSeekTime
            // 
            this.txtBoxAutoSeekTime.Location = new System.Drawing.Point(65, 25);
            this.txtBoxAutoSeekTime.Name = "txtBoxAutoSeekTime";
            this.txtBoxAutoSeekTime.Size = new System.Drawing.Size(189, 23);
            this.txtBoxAutoSeekTime.TabIndex = 1;
            this.txtBoxAutoSeekTime.MouseEnter += new System.EventHandler(this.txtBoxAutoSeekTime_MouseEnter);
            this.txtBoxAutoSeekTime.MouseLeave += new System.EventHandler(this.HideTT);
            this.txtBoxAutoSeekTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxAutoSeekTime_Validating);
            // 
            // cBoxAutoSeekEnabled
            // 
            this.cBoxAutoSeekEnabled.AutoSize = true;
            this.cBoxAutoSeekEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.cBoxAutoSeekEnabled.Location = new System.Drawing.Point(6, 0);
            this.cBoxAutoSeekEnabled.Name = "cBoxAutoSeekEnabled";
            this.cBoxAutoSeekEnabled.Size = new System.Drawing.Size(79, 19);
            this.cBoxAutoSeekEnabled.TabIndex = 0;
            this.cBoxAutoSeekEnabled.Text = "Auto Seek";
            this.cBoxAutoSeekEnabled.UseVisualStyleBackColor = false;
            this.cBoxAutoSeekEnabled.CheckedChanged += new System.EventHandler(this.RefreshUI);
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.gBoxMisc);
            this.tabMisc.Location = new System.Drawing.Point(4, 24);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(420, 398);
            this.tabMisc.TabIndex = 1;
            this.tabMisc.Text = "Misc";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // gBoxMisc
            // 
            this.gBoxMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxMisc.Location = new System.Drawing.Point(3, 3);
            this.gBoxMisc.Name = "gBoxMisc";
            this.gBoxMisc.Size = new System.Drawing.Size(414, 392);
            this.gBoxMisc.TabIndex = 0;
            this.gBoxMisc.TabStop = false;
            this.gBoxMisc.Text = "Misc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDiscardChanges);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(270, 432);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 29);
            this.panel1.TabIndex = 3;
            // 
            // btnDiscardChanges
            // 
            this.btnDiscardChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscardChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDiscardChanges.FlatAppearance.BorderSize = 0;
            this.btnDiscardChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscardChanges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiscardChanges.Location = new System.Drawing.Point(288, 3);
            this.btnDiscardChanges.Name = "btnDiscardChanges";
            this.btnDiscardChanges.Size = new System.Drawing.Size(62, 23);
            this.btnDiscardChanges.TabIndex = 1;
            this.btnDiscardChanges.Text = "&Cancel";
            this.btnDiscardChanges.UseVisualStyleBackColor = true;
            this.btnDiscardChanges.Click += new System.EventHandler(this.btnDiscardChanges_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChanges.Location = new System.Drawing.Point(356, 3);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "&Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tt
            // 
            this.tt.AutomaticDelay = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.tableLayoutMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.tableLayoutMain.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.tabControler.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.gBoxGeneral.ResumeLayout(false);
            this.flowLayoutGeneral.ResumeLayout(false);
            this.flowLayoutGeneral.PerformLayout();
            this.tabClips.ResumeLayout(false);
            this.bBoxClips.ResumeLayout(false);
            this.pThumbnailGenerator.ResumeLayout(false);
            this.gBoxThumbnailGenerator.ResumeLayout(false);
            this.gBoxThumbnailGenerator.PerformLayout();
            this.pAutoSeek.ResumeLayout(false);
            this.gBoxAutoSeek.ResumeLayout(false);
            this.gBoxAutoSeek.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private Panel pSearch;
        private Button btnSearch;
        private TextBox tBoxSearch;
        private TreeView treeViewSearch;
        private TabControl tabControler;
        private TabPage tabGeneral;
        private TabPage tabMisc;
        private GroupBox gBoxGeneral;
        private GroupBox gBoxMisc;
        private Panel panel1;
        private Button btnDiscardChanges;
        private Button btnSaveChanges;
        private TabPage tabClips;
        private GroupBox bBoxClips;
        private GroupBox gBoxAutoSeek;
        private CheckBox cBoxAutoSeekEnabled;
        private Label label1;
        private TextBox txtBoxAutoSeekTime;
        private CheckBox cBoxThumbGenIgnoreWarning;
        private ToolTip tt;
        private Panel pAutoSeek;
        private Panel pThumbnailGenerator;
        private GroupBox gBoxThumbnailGenerator;
        private CheckBox cBoxThumbnailGeneratorEnabled;
        private Label label2;
        private TextBox txtBoxThumbGenTime;
        private FlowLayoutPanel flowLayoutGeneral;
        private CheckBox cBoxTopMostWhileReviewing;
        private ErrorProvider errorProvider1;
        private CheckBox cBoxThumbGenUseCached;
        private Button btnThumbGenClearCached;
    }
}