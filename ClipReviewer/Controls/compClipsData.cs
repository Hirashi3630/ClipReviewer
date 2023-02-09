using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using ClipReviewer.Utils;
using System.Text.RegularExpressions;

namespace ClipReviewer.Controls
{
    public partial class compClipsData : UserControl
    {
        public IEnumerable<FileInfo> GetClipFiles(string folderPath) => new DirectoryInfo(folderPath).GetFilesByExtensions(".mp4", ".avi", ".mkv");
        private static bool IsPathValid(string path)
            => new Regex("^(?:[a-zA-Z]:|\\\\\\\\[\\w\\.]+\\\\[\\w.$]+)\\\\(?:[\\w\\s]+\\\\)*[\\w\\s]+$").IsMatch(path);

        public bool isClipFolderValid =>
            IsPathValid(txtBoxClipsFolderLocation.Text) && Directory.Exists(txtBoxClipsFolderLocation.Text);


        private int m_LockedSelection = -1;
        public int LockedSelection { get => m_LockedSelection; 
            set
            {
                m_LockedSelection = value;
                if(value >= 0 && value < dataGridView1.RowCount)
                    dataGridView1.Rows[value].Selected = true;
            }
        }
        public List<Clip> Clips { get; set; }

        public compClipsData()
        {
            InitializeComponent();
        }

        private void RefreshUI()
        {
            // clips folder location
            var isValid = isClipFolderValid;
            txtBoxClipsFolderLocation.BackColor =
                isValid || string.IsNullOrEmpty(txtBoxClipsFolderLocation.Text)
                ? Color.White : Color.MistyRose;
            btnClipDataLoad.Enabled = isValid;
        }

        public async Task<List<Clip>> LoadClips(string folderPath)
        {
            Clips = new List<Clip>();
            progressBar1.Value = 0;

            // populate
            IEnumerable<FileInfo> fileEntries = GetClipFiles(folderPath);
            progressBar1.Maximum = fileEntries.Count();

            List<Task<Clip>> TaskList = new List<Task<Clip>>();
            uint i = 0;
            foreach (var f in fileEntries)
            {
                var LastTask = Clip.New(i++, f.FullName);
                TaskList.Add(LastTask);
                Clips.Add(LastTask.Result);
                progressBar1.Increment(1);
            }

            await Task.WhenAll(TaskList.ToArray()).ContinueWith((x) => { Console.WriteLine("Finished"); });

            // set source
            Console.WriteLine("Finished?");
            dataGridView1.DataSource = Clips;
            return Clips;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (LockedSelection >= 0 && dataGridView1.CurrentCell.RowIndex != LockedSelection)
                dataGridView1.Rows[LockedSelection].Selected = true;
        }

        private async void btnClipDataLoad_Click(object sender, EventArgs e)
        {
            //// load clips to datagrid
            //dataGridView1.
            await LoadClips(txtBoxClipsFolderLocation.Text);
        }

        private void btnClipsFolderBrowse_Click(object sender, EventArgs e)
        {
            if (clipsFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxClipsFolderLocation.Text = clipsFolderDialog.SelectedPath;
            }
        }

        private void txtBoxClipsFolderLocation_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
            if (isClipFolderValid)
            {
                int clipsCount = GetClipFiles(txtBoxClipsFolderLocation.Text).Count();
                btnClipDataLoad.Text = $"Load ({clipsCount})";
            }
        }
    }
}
