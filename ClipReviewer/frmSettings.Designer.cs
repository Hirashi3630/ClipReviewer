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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Clip Review");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Misc");
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.treeViewSearch = new System.Windows.Forms.TreeView();
            this.tabControler = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.gBoxGeneral = new System.Windows.Forms.GroupBox();
            this.tabClipReview = new System.Windows.Forms.TabPage();
            this.bBoxClipReview = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pClipReviewAutoSeek = new System.Windows.Forms.Panel();
            this.gBoxClipReviewAutoSeek = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxClipReviewAutoSeekTime = new System.Windows.Forms.TextBox();
            this.cBoxClipReviewAutoSeekEnabled = new System.Windows.Forms.CheckBox();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.gBoxMisc = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiscardChanges = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.ttSeekToTxtBox = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutMain.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.tabControler.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabClipReview.SuspendLayout();
            this.bBoxClipReview.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pClipReviewAutoSeek.SuspendLayout();
            this.gBoxClipReviewAutoSeek.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.panel1.SuspendLayout();
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
            treeNode4.Name = "General";
            treeNode4.Text = "General";
            treeNode5.Name = "ClipReview";
            treeNode5.Text = "Clip Review";
            treeNode6.Name = "Misc";
            treeNode6.Text = "Misc";
            this.treeViewSearch.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeViewSearch.Size = new System.Drawing.Size(250, 380);
            this.treeViewSearch.TabIndex = 0;
            this.treeViewSearch.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSearch_AfterSelect);
            // 
            // tabControler
            // 
            this.tabControler.Controls.Add(this.tabGeneral);
            this.tabControler.Controls.Add(this.tabClipReview);
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
            this.gBoxGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxGeneral.Location = new System.Drawing.Point(3, 3);
            this.gBoxGeneral.Name = "gBoxGeneral";
            this.gBoxGeneral.Size = new System.Drawing.Size(414, 392);
            this.gBoxGeneral.TabIndex = 0;
            this.gBoxGeneral.TabStop = false;
            this.gBoxGeneral.Text = "General";
            // 
            // tabClipReview
            // 
            this.tabClipReview.Controls.Add(this.bBoxClipReview);
            this.tabClipReview.Location = new System.Drawing.Point(4, 24);
            this.tabClipReview.Name = "tabClipReview";
            this.tabClipReview.Padding = new System.Windows.Forms.Padding(3);
            this.tabClipReview.Size = new System.Drawing.Size(420, 398);
            this.tabClipReview.TabIndex = 2;
            this.tabClipReview.Text = "ClipReview";
            this.tabClipReview.UseVisualStyleBackColor = true;
            // 
            // bBoxClipReview
            // 
            this.bBoxClipReview.Controls.Add(this.flowLayoutPanel1);
            this.bBoxClipReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBoxClipReview.Location = new System.Drawing.Point(3, 3);
            this.bBoxClipReview.Name = "bBoxClipReview";
            this.bBoxClipReview.Size = new System.Drawing.Size(414, 392);
            this.bBoxClipReview.TabIndex = 0;
            this.bBoxClipReview.TabStop = false;
            this.bBoxClipReview.Text = "Clip Review";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pClipReviewAutoSeek);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(408, 370);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pClipReviewAutoSeek
            // 
            this.pClipReviewAutoSeek.Controls.Add(this.gBoxClipReviewAutoSeek);
            this.pClipReviewAutoSeek.Location = new System.Drawing.Point(0, 0);
            this.pClipReviewAutoSeek.Margin = new System.Windows.Forms.Padding(0);
            this.pClipReviewAutoSeek.Name = "pClipReviewAutoSeek";
            this.pClipReviewAutoSeek.Size = new System.Drawing.Size(408, 100);
            this.pClipReviewAutoSeek.TabIndex = 2;
            // 
            // gBoxClipReviewAutoSeek
            // 
            this.gBoxClipReviewAutoSeek.Controls.Add(this.label1);
            this.gBoxClipReviewAutoSeek.Controls.Add(this.txtBoxClipReviewAutoSeekTime);
            this.gBoxClipReviewAutoSeek.Controls.Add(this.cBoxClipReviewAutoSeekEnabled);
            this.gBoxClipReviewAutoSeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxClipReviewAutoSeek.Location = new System.Drawing.Point(0, 0);
            this.gBoxClipReviewAutoSeek.Name = "gBoxClipReviewAutoSeek";
            this.gBoxClipReviewAutoSeek.Size = new System.Drawing.Size(408, 100);
            this.gBoxClipReviewAutoSeek.TabIndex = 1;
            this.gBoxClipReviewAutoSeek.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seek to:";
            // 
            // txtBoxClipReviewAutoSeekTime
            // 
            this.txtBoxClipReviewAutoSeekTime.Location = new System.Drawing.Point(60, 25);
            this.txtBoxClipReviewAutoSeekTime.Name = "txtBoxClipReviewAutoSeekTime";
            this.txtBoxClipReviewAutoSeekTime.Size = new System.Drawing.Size(189, 23);
            this.txtBoxClipReviewAutoSeekTime.TabIndex = 1;
            this.ttSeekToTxtBox.SetToolTip(this.txtBoxClipReviewAutoSeekTime, "Time that you want to automatically seek to\r\nType % at the end if you want to use" +
        " percentages\r\nUsage: 13 or 50%\r\nDefault: 0");
            // 
            // cBoxClipReviewAutoSeekEnabled
            // 
            this.cBoxClipReviewAutoSeekEnabled.AutoSize = true;
            this.cBoxClipReviewAutoSeekEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.cBoxClipReviewAutoSeekEnabled.Location = new System.Drawing.Point(6, 0);
            this.cBoxClipReviewAutoSeekEnabled.Name = "cBoxClipReviewAutoSeekEnabled";
            this.cBoxClipReviewAutoSeekEnabled.Size = new System.Drawing.Size(79, 19);
            this.cBoxClipReviewAutoSeekEnabled.TabIndex = 0;
            this.cBoxClipReviewAutoSeekEnabled.Text = "Auto Seek";
            this.cBoxClipReviewAutoSeekEnabled.UseVisualStyleBackColor = false;
            this.cBoxClipReviewAutoSeekEnabled.CheckedChanged += new System.EventHandler(this.RefreshUI);
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
            this.btnDiscardChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChanges.Location = new System.Drawing.Point(356, 3);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "&Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
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
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            this.tableLayoutMain.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.tabControler.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabClipReview.ResumeLayout(false);
            this.bBoxClipReview.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pClipReviewAutoSeek.ResumeLayout(false);
            this.gBoxClipReviewAutoSeek.ResumeLayout(false);
            this.gBoxClipReviewAutoSeek.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private TabPage tabClipReview;
        private GroupBox bBoxClipReview;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox gBoxClipReviewAutoSeek;
        private CheckBox cBoxClipReviewAutoSeekEnabled;
        private Panel pClipReviewAutoSeek;
        private Label label1;
        private TextBox txtBoxClipReviewAutoSeekTime;
        private ToolTip ttSeekToTxtBox;
    }
}