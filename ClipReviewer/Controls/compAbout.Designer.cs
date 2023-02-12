namespace ClipReviewer.Controls
{
    partial class compAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.labelURL = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.labelAuthor, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelURL, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(315, 129);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAuthor.Location = new System.Drawing.Point(135, 25);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelAuthor.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(176, 20);
            this.labelAuthor.TabIndex = 22;
            this.labelAuthor.Text = "Author";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(135, 50);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(176, 20);
            this.labelVersion.TabIndex = 21;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::ClipReviewer.Properties.Resources.ClipReviewer_Icon_v1_128;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 5);
            this.logoPictureBox.Size = new System.Drawing.Size(128, 129);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductName.Location = new System.Drawing.Point(135, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(176, 20);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(223, 105);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 21);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&Close";
            this.okButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelURL.Location = new System.Drawing.Point(135, 75);
            this.labelURL.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelURL.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(176, 20);
            this.labelURL.TabIndex = 25;
            this.labelURL.TabStop = true;
            this.labelURL.Text = "URL";
            this.labelURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelURL_LinkClicked);
            // 
            // compAbout
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 149);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "compAbout";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "compAbout";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button okButton;
        private Label labelVersion;
        private LinkLabel labelURL;
        private Label labelAuthor;
    }
}
