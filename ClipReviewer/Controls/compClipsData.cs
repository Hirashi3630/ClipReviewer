using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using ClipReviewer.Utils;

namespace ClipReviewer.Controls
{
    public partial class compClipsData : UserControl
    {
        public IEnumerable<FileInfo> GetClipFiles(string folderPath) => new DirectoryInfo(folderPath).GetFilesByExtensions(".mp4", ".avi", ".mkv");
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
