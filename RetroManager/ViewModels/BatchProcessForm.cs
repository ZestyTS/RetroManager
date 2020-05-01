using System;
using System.Threading;
using System.Windows.Forms;

using RetroManager.Models;

namespace RetroManager
{
    public partial class BatchProcessForm : Form
    {
        public BatchProcessForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbRegion.Checked)
            {

                var task = new Thread(() =>
                {
                    var model = new RegionDuplicateRemover();
                    var drf = new DuplicateRemoverForm(model);
                    drf.Show();
                });
                task.Start();
                //task.Join();
            }
            if (cbRevision.Checked)
            {
                var model = new RevisionDuplicateRemover();
                new DuplicateRemoverForm(model).Show();
            }
            if (cbCompress.Checked)
            {
                new CompressRomForm().Show();
            }

            if (cbRootRoms.Checked)
            {
                new RootFolderForm().Show();
            }
        }
    }
}
