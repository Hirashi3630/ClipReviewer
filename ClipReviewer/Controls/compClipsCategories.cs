using System.Data;
using System.Text.RegularExpressions;

namespace ClipReviewer
{
    public partial class compClipsCategories : UserControl
    {
        public List<string> Categories => listBox.Items.Cast<string>().ToList();
        public Action<string> CategorySelected = delegate { };

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

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = listBox.SelectedItem as string;
            Console.WriteLine(item);
            if (!string.IsNullOrEmpty(item))
                CategorySelected.Invoke(item);
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
