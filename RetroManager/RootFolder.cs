using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroManager
{
    public partial class RootFolder : Form
    {
        public RootFolder()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            txtDirectory.Text = RedudantHelper.Browse(txtDirectory.Text);
        }
    }
}
