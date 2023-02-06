namespace ClipReviewer
{
    partial class compClipsCategories
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gBox.Controls.Add(this.btnClear);
            this.gBox.Controls.Add(this.txtBox);
            this.gBox.Controls.Add(this.btnAdd);
            this.gBox.Controls.Add(this.btnDelete);
            this.gBox.Controls.Add(this.listBox);
            this.gBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBox.Location = new System.Drawing.Point(0, 0);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(594, 541);
            this.gBox.TabIndex = 5;
            this.gBox.TabStop = false;
            this.gBox.Text = "Categories";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(513, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBox
            // 
            this.txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox.Location = new System.Drawing.Point(6, 22);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(501, 23);
            this.txtBox.TabIndex = 5;
            this.txtBox.TextChanged += new System.EventHandler(this.RefreshUI);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(513, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(513, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Items.AddRange(new object[] {
            "Death",
            "Funny",
            "Kill",
            "Kill/Snipe",
            "Kill/Wicked",
            "Trash"});
            this.listBox.Location = new System.Drawing.Point(6, 51);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(501, 484);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.RefreshUI);
            // 
            // compClipsCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBox);
            this.Name = "compClipsCategories";
            this.Size = new System.Drawing.Size(594, 541);
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gBox;
        private TextBox txtBox;
        private Button btnAdd;
        private Button btnDelete;
        private ListBox listBox;
        private Button btnClear;
    }
}
