using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RetroManager
{
    public partial class DuplicateRemover : Form
    {
        private ArrayList _deleteList;
        public DuplicateRemover(bool region=false)
        {
            InitializeComponent();
            if (region) return;

            Name = "Revision Duplicate Remover";
            lbRegions.Visible = false;
            txtRegions.Visible = false;
            lbDirectory.Location = new Point(lbDirectory.Location.X, lbDirectory.Location.Y - 53);
            txtDirectory.Location = new Point(txtDirectory.Location.X, txtDirectory.Location.Y - 53);
            btnBrowse.Location = new Point(btnBrowse.Location.X, btnBrowse.Location.Y-53);
            btnAnalyze.Location = new Point(btnAnalyze.Location.X, btnAnalyze.Location.Y - 53);
            btnDelete.Location = new Point(btnDelete.Location.X, btnDelete.Location.Y-53);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDirectory.Text))
            {
                MessageBox.Show(@"Directory field can not be empty");
                return;
            }
            var reader = txtDirectory.Text;
            var directorycheck = Directory.Exists(reader);
            _deleteList = new ArrayList();

            if (!directorycheck)
            {
                MessageBox.Show(@"Please enter a valid directory.");
                return;
            }

            var files = Directory.GetFiles(reader, "*.*", SearchOption.AllDirectories);
            var priority = txtRegions.Text.Replace(" ", string.Empty).Split(',').ToList();
            var regionMap = new Dictionary<string, ArrayList>();
            var regex = new Regex(@"\s*?(?:\(.*?\)|\[.*?\]|\{.*?\})");

            foreach (var file in files)
            {
                var region = regex.Matches(file).Cast<Match>().Aggregate("", (current, match) => current + match.Value);
                var title = Path.GetFileName(string.IsNullOrWhiteSpace(region) ? file : file.Replace(region, string.Empty));

                region = region.Trim();

                if (regionMap.ContainsKey(title))
                    regionMap[title].Add(region);
                else
                    regionMap[title] = new ArrayList { region };
            }

            foreach (var file in files)
            {
                var region = regex.Matches(file).Cast<Match>().Aggregate("", (current, match) => current + match.Value);
                var title = Path.GetFileName(string.IsNullOrWhiteSpace(region) ? file : file.Replace(region, string.Empty));
                region = region.Trim();

                if (regionMap[title].Count < 2)
                    continue;

                var number = priority.IndexOf(region);

                if (number == -1)
                {
                    _deleteList.Add(file);
                    continue;
                }

                var list = new ArrayList();
                foreach (string rank in regionMap[title])
                {
                    if (!(priority.IndexOf(rank) < 0))
                        list.Add(priority.IndexOf(rank));
                }

                list.Sort();

                if (list.IndexOf(number) != 0)
                {
                    _deleteList.Add(file);
                }
            }

            if (_deleteList.Count > 0)
            {
                var filename = "RetroManagerDuplicates";
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var duplicatefile = Directory.GetFiles(path, "RetroManagerDuplicates*.txt");
                
                if (!(duplicatefile == null || duplicatefile.Length == 0))
                {
                    duplicatefile = duplicatefile.OrderByDescending(c => c).ToArray();
                    var num = new string(duplicatefile[0].Where(char.IsDigit).ToArray());

                    filename += string.IsNullOrWhiteSpace(num) ? "1" : (Convert.ToInt16(num) + 1) + "";
                }

                filename += ".txt";
                var filepath = path + filename;
                using (var sw = new StreamWriter(filepath))
                {
                    foreach (string w in _deleteList)
                        sw.WriteLine(w);
                }
                System.Diagnostics.Process.Start(filepath);
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show(@"No duplicate found");
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                var result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                    txtDirectory.Text = folderDialog.SelectedPath;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (string file in _deleteList)
            {
                if (File.Exists(file))
                    File.Delete(file);
            }
            MessageBox.Show(@"Duplicates Deleted");
            btnDelete.Enabled = false;
        }

        private void DuplicateRemover_Load(object sender, EventArgs e)
        { 
            ttRegions.IsBalloon = true;
            ttDirectory.IsBalloon = true;
            ttRegions.SetToolTip(lbRegions, "Write the priority of certain regions, whatever is not written will fall under the same priority level.\nExample: (USA), (Europe), (Japan)\nKeep in mind that some regions might be written as [U] instead.");
            ttDirectory.SetToolTip(lbDirectory, "Put the root directory of the roms that will be checked for duplicates, subdirectories will also be checked. \nCurrently checking across multiple emulators at the same time will yield results undesired.");
        }
    }
}
