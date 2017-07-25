using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Linq;

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

        private void BtnMove_Click(object sender, EventArgs e)
        {
            var reader = txtDirectory.Text;
            if (!RedudantHelper.DirectoryCheck(reader)) return;
            
            var files = from f in Directory.GetFiles(reader, "*.*", SearchOption.AllDirectories) where !Path.GetDirectoryName(f).EndsWith(new DirectoryInfo(reader).Name) select f;
            var failfolder = new ArrayList();
            if (cbRename.Checked)
            {
                foreach (var file in files)
                {
                    var newfile = Path.GetDirectoryName(file) + @"\" + new FileInfo(file).Directory.Name + Path.GetExtension(file);
                    if (!File.Exists(newfile))
                        File.Move(file, newfile);
                    else
                        failfolder.Add(newfile);
                }
            }

            RedudantHelper.FileMaker(failfolder, "FileFolderRenamer");

            if (!reader.EndsWith(@"\"))
                reader = reader + @"\";

            files = from f in Directory.GetFiles(reader, "*.*", SearchOption.AllDirectories) where !Path.GetDirectoryName(f).EndsWith(new DirectoryInfo(reader).Name) select f;
            var fail = new ArrayList();
            foreach (var file in files)
            {
                var newfile = reader + Path.GetFileName(file);
                if (!File.Exists(newfile))
                    File.Move(file, newfile);
                else
                    fail.Add(newfile);
            }

            RedudantHelper.FileMaker(fail, "MoveToRootFolder");
        }

        private void RootFolder_Load(object sender, EventArgs e)
        {
            ttDirectory.IsBalloon = true;
            ttR.IsBalloon = true;
            ttR.SetToolTip(cbRename,
                "Files in subdirectories will have their name be changed to the folder they were in before being moved.");
            ttDirectory.SetToolTip(lbDirectory, "Put the root directory of where the roms will be moved to.");
        }
    }
}
