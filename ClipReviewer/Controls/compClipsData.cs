﻿using ClipReviewer.Utils;
using CSRakowski.Parallel;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq.Dynamic;
using System.Collections;

namespace ClipReviewer.Controls
{
    public partial class compClipsData : UserControl
    {
        private bool m_ReviewInProgress = false;
        public bool ReviewInProgress
        {
            get => m_ReviewInProgress;
            set
            {
                m_ReviewInProgress = value;
                
                dataGridView1_SelectionChanged(null, null);
            }
        }

        private int m_LockedSelection = -1;
        public int LockedSelection
        {
            get => m_LockedSelection;
            set
            {
                m_LockedSelection = value;
                // TODO: focus on selected 
                if (value >= 0 && value < dataGridView1.RowCount && ReviewInProgress)
                    dataGridView1.Rows[value].Selected = true;
            }
        }

        public IEnumerable<FileInfo> GetClipFiles(string folderPath) => new DirectoryInfo(folderPath).GetFilesByExtensions(".mp4", ".avi", ".mkv");
        private static bool IsPathValid(string path)
            => new Regex("^(?:[a-zA-Z]:|\\\\\\\\[\\w\\.]+\\\\[\\w.$]+)\\\\(?:[\\w\\s]+\\\\)*[\\w\\s]+$").IsMatch(path);

        public List<Clip> Clips { get; set; }

        public compClipsData()
        {
            InitializeComponent();
            RefreshUI(null, null);
        }

        private void RefreshUI(object sender, EventArgs e)
        {
            // clips folder location
            var isValid = IsPathValid(txtBoxClipsFolderLocation.Text) && Directory.Exists(txtBoxClipsFolderLocation.Text);
            if (isValid)
            {
                int clipsCount = GetClipFiles(txtBoxClipsFolderLocation.Text).Count();
                btnLoad.Text = $"Load ({clipsCount})";
                isValid = clipsCount > 0;
            }
            txtBoxClipsFolderLocation.BackColor =
                isValid || string.IsNullOrEmpty(txtBoxClipsFolderLocation.Text)
                ? Color.White : Color.MistyRose;
            btnLoad.Enabled = isValid;

            btnUnload.Enabled = Clips != null && Clips.Count > 0;
        }

        public void SortDataGridViewByProperty(string property, ref bool ascending)
        {
            System.Reflection.PropertyInfo? prop = typeof(Clip).GetProperty(property);
            if (prop != null)
            {
                if (ascending)
                    dataGridView1.DataSource = Clips.OrderBy(x => prop.GetValue(x, null)).ToList();
                else
                    dataGridView1.DataSource = Clips.OrderBy(x => prop.GetValue(x, null)).Reverse().ToList();
                ascending = !ascending;
            }
        }

        public async Task<List<Clip>> LoadClips(string folderPath, bool slowMethod = false)
        {
            Clips = new List<Clip>();
            progressBar1.Value = 0;
            this.Enabled = false;

            // populate
            IEnumerable<FileInfo> fileEntries = GetClipFiles(folderPath);
            progressBar1.Maximum = fileEntries.Count();


            if (slowMethod)
            {
                uint i = 0;
                foreach (var f in fileEntries)
                {
                    Clips.Add(await Clip.New(f.FullName, id: i++));
                    progressBar1.Increment(1);
                }
            }
            else
            {
                var clips = await ParallelAsync.ForEachAsync(fileEntries, (f) =>
                {
                    return Clip.New(f.FullName);
                }, maxBatchSize: 0, allowOutOfOrderProcessing: true);

                uint i = 0;
                foreach (var c in clips)
                {
                    c.ID = i++;
                    Clips.Add(c);
                    progressBar1.Increment(1); // TODO: somehow make progress bar work in parallelasync
                }
            }

            Console.WriteLine("All Clips added!");
            dataGridView1.DataSource = Clips;
            dataGridView1.AutoResizeColumns();
            this.Enabled = true;
            return Clips;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // dataGridView1.CurrentCell?.RowIndex != LockedSelection
            if (LockedSelection >= 0 && LockedSelection < dataGridView1.RowCount && ReviewInProgress)
                dataGridView1.Rows[LockedSelection].Selected = true;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            //// load clips to datagrid
            //dataGridView1.
            bool slow = false;
            DialogResult result = MsgBox.Question(
                "There is an issue with Antimalware Execution Service slowing down this process.\r\n\r\n" +
                "(this applies mainly when creating thumbnails)\r\n" +
                "(Progress bar below data grid works only in slow load!)\r\n\r\n" +
                "Do you want to proceed with slow load? (low CPU usage)");
            if (result == DialogResult.Yes)
                slow = true;
            else if (result == DialogResult.No)
                slow = false;
            else return;

            await LoadClips(txtBoxClipsFolderLocation.Text, slow);
            RefreshUI(null, null);
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Clips.Clear();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (clipsFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxClipsFolderLocation.Text = clipsFolderDialog.SelectedPath;
            }
        }

        #region KeyBinds & Shortcuts
        private bool dataSortAscending = false;
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SortDataGridViewByProperty(dataGridView1.Columns[e.ColumnIndex].DataPropertyName, ref dataSortAscending);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                dataGridView1.AutoResizeColumns();
        }
        #endregion

        private void btnUnload_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}