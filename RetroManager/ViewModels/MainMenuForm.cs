using System;
using System.Windows.Forms;

using RetroManager.Models;

namespace RetroManager
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void BtnRegion_Click(object sender, EventArgs e)
        {
            var model = new RegionDuplicateRemover();
            new DuplicateRemoverForm(model).Show();
        }

        private void BtnRevision_Click(object sender, EventArgs e)
        {
            var model = new RevisionDuplicateRemover();
            new DuplicateRemoverForm(model);
        }

        private void BtnCompress_Click(object sender, EventArgs e)
        {
            new CompressRomForm().Show();
        }

        private void BtnFolderMove_Click(object sender, EventArgs e)
        {
            new RootFolderForm().Show();
        }
    }
}
