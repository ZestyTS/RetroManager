using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroManager
{
    public partial class DuplicateRemover : Form
    {
        public DuplicateRemover()
        {
            InitializeComponent();
        }

        private void DuplicateRemover_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDirectory.Text))
            {
                MessageBox.Show("Directory field can not be empty");
                return;
            }
            var reader = txtDirectory.Text;
            var directorycheck = Directory.Exists(reader);
            var deleteList = new ArrayList();

            if (!directorycheck)
            {
                MessageBox.Show("Please enter a valid directory.");
                return;
            }

            var files = Directory.GetFiles(reader);
            var priority = new ArrayList { "(USA)", "(Europe)", "(Japan)" };
            var regionMap = new Dictionary<string, ArrayList>();
            var regex = new Regex(@"\s*?(?:\(.*?\)|\[.*?\]|\{.*?\})");

            foreach (var file in files)
            {
                var region = regex.Matches(file).Cast<Match>().Aggregate("", (current, match) => current + match.Value);
                var title = Path.GetFileName(string.IsNullOrEmpty(region) ? file : file.Replace(region, string.Empty));

                region = region.Trim();

                if (regionMap.ContainsKey(title))
                    regionMap[title].Add(region);
                else
                    regionMap[title] = new ArrayList { region };
            }

            foreach (var file in files)
            {
                var region = regex.Matches(file).Cast<Match>().Aggregate("", (current, match) => current + match.Value);
                var title = Path.GetFileName(string.IsNullOrEmpty(region) ? file : file.Replace(region, string.Empty));
                region = region.Trim();

                if (regionMap[title].Count < 2)
                    continue;

                var number = priority.IndexOf(region);

                if (number == -1)
                {
                    deleteList.Add(file);
                    continue;
                }

                var list = new ArrayList();
                foreach (var rank in regionMap[title])
                {
                    if (!(priority.IndexOf(rank) < 0))
                        list.Add(priority.IndexOf(rank));
                }

                list.Sort();

                if (list.IndexOf(number) != 0)
                {
                    deleteList.Add(file);
                }
            }

            if (deleteList.Count > 0)
            {
                foreach (var file in deleteList)
                    lbFiles.Items.Add(file);
            }
            else
            {
                lbFiles.Items.Add("No duplicate found");
            }
        }

        private static void Delete(string file)
        {
            File.Delete(file);
        }

    }
}
