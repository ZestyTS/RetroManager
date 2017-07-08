using System;
using System.Windows.Forms;

namespace RetroManager
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnRegion_Click(object sender, EventArgs e)
        {
            var dr = new DuplicateRemover();
            dr.Show();
        }

        private void BtnRevision_Click(object sender, EventArgs e)
        {
            var dr = new DuplicateRemover(true);
            dr.Show();
        }
    }
}
