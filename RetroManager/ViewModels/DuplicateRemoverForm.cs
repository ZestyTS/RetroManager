using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using RetroManager.Models;

namespace RetroManager
{
    public partial class DuplicateRemoverForm : Form
    {
        private IDuplicateRemover model;

        public DuplicateRemoverForm(IDuplicateRemover model)
        {
            InitializeComponent();

            this.model = model;

            if (model is RegionDuplicateRemover)
            {
                return;
            }

            Text = @"Revision Duplicate Remover";
            Size = new Size(Width, Height - 53);
            lbRegions.Visible = false;
            txtRegions.Visible = false;
            lbDirectory.Location = new Point(lbDirectory.Location.X, lbDirectory.Location.Y - 53);
            txtDirectory.Location = new Point(txtDirectory.Location.X, txtDirectory.Location.Y - 53);
            btnBrowse.Location = new Point(btnBrowse.Location.X, btnBrowse.Location.Y - 53);
            btnAnalyze.Location = new Point(btnAnalyze.Location.X, btnAnalyze.Location.Y - 53);
            btnDelete.Location = new Point(btnDelete.Location.X, btnDelete.Location.Y - 53);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegions.Text) && model is RegionDuplicateRemover)
            {
                MessageBox.Show(@"Revision field cannot be empty");
                return;
            }

            var files = Directory.EnumerateFiles(txtDirectory.Text, "*.*", SearchOption.AllDirectories);
            var priority = model is RegionDuplicateRemover ?
                txtRegions.Text.Replace(" ", string.Empty).Split(',').ToList() : RedundantHelper.Alphabet;

            RedundantHelper.FileMaker(new ArrayList(model.dryRun(files, priority)), "DuplicateRemover");
            btnDelete.Enabled = true;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            txtDirectory.Text = RedundantHelper.Browse(txtDirectory.Text);
            RedundantHelper.DirectoryCheck(txtDirectory.Text);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            model.delete();

            MessageBox.Show(@"Duplicates Deleted");
            btnDelete.Enabled = false;
        }

        private void DuplicateRemover_Load(object sender, EventArgs e)
		{
			txtDirectory.Text = RedundantHelper.GetDefaultDirectory();
            ttRegions.IsBalloon = true;
            ttDirectory.IsBalloon = true;
            ttRegions.SetToolTip(lbRegions, "Write the priority of certain regions, whatever is not written will fall under the same priority level.\nExample: (USA), (Europe), (Japan)\nKeep in mind that some regions might be written as [U] instead.");
            ttDirectory.SetToolTip(lbDirectory, "Put the root directory of the roms that will be checked for duplicates, subdirectories will also be checked. \nCurrently checking across multiple emulators at the same time will yield results undesired.");
        }
    }
}
