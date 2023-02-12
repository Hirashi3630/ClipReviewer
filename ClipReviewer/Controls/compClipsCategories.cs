using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipReviewer
{
    public partial class compClipsCategories : UserControl
    {
        private bool m_ReviewInProgress = false;
        public bool ReviewInProgress
        {
            get => m_ReviewInProgress;
            set
            {
                m_ReviewInProgress = value;
                
                pButtons.Enabled = !value;
            }
        }

        public List<string> Categories => listBox.Items.Cast<string>().ToList();

        public compClipsCategories()
        {
            InitializeComponent();
            RefreshUI();
        }
        
        public void Unselect() 
        {
            // reset selection
            listBox.SelectedIndex = -1;
            RefreshUI();
        }

        private void RefreshUI(object sender = default, EventArgs e = default)
        {
            // enable / disable add button
            btnAdd.Enabled = IsTxtBoxValid();

            // enable/disable delete button
            btnDelete.Enabled = listBox.SelectedItems.Count > 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(txtBox.Text);
            txtBox.Text = string.Empty;
            RefreshUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtBox.Text = listBox.SelectedItem as string;
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            RefreshUI();
        }

        private bool IsTxtBoxValid()
        {
            var txt = txtBox.Text;
            return
                new Regex("^(?:[\\w]+\\/)*\\w+$").IsMatch(txt) &&
                !listBox.Items.Contains(txtBox.Text) &&
                !string.IsNullOrEmpty(txt) && !string.IsNullOrWhiteSpace(txt);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
