using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroManager
{
    public partial class CompressRom : Form
    {
        public CompressRom()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            const string sixfour = @"C:\Program Files\7-Zip\7z.exe";
            const string threetwo = @"C:\Program Files (x86)\7-Zip\7z.exe";
            var reader = txtDirectory.Text;
            string process;

            if (!RedudantHelper.DirectoryCheck(reader)) return;

            if (File.Exists(sixfour))
                process = sixfour;
            else if (File.Exists(threetwo))
                process = threetwo;
            else
            {
                MessageBox.Show(@"7zip's location can not be determined");
                return;
            }

            var p = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = process
            };

            if (cbExtract.Checked)
            {
                var extract = Directory.GetFiles(reader, "*.zip", SearchOption.AllDirectories);
                foreach (var rom in extract)
                {

                    /*  var extraction = Path.GetDirectoryName(rom) + @"\Compress-RetroManager";
                        if (!Directory.Exists(extraction))
                            Directory.CreateDirectory(extraction);
                            p.Arguments = "x " + rom + " -aoa -o" + extraction;
                     */
                    p.Arguments = "e " + rom;
                    var x = Process.Start(p);
                    x.WaitForExit();
                }
            }

            var extensions =
                new Dictionary<string, ArrayList>
                {
                    {"nes", new ArrayList {"nes", "smc", "sfc", "fig", "swc", "mgd", "fds"}},
                    {"sg-1000", new ArrayList {"sg"}},
                    {"snes", new ArrayList {"smc", "sfc", "fig", "swc"}},
                    {"gb", new ArrayList {"gb"}},
                    {"gbc", new ArrayList {"gbc"}},
                    {"gba", new ArrayList {"gba"}},
                    {"ds", new ArrayList {"nds"}},
                    {"32x", new ArrayList {"32x", "smd", "bin", "md"}},
                    {"genesis", new ArrayList {"smd", "bin", "md", "iso"}},
                    {"n64", new ArrayList {"z64", "n64", "v64"}},
                    {"mastersystem", new ArrayList {"sms"}},
                    {"atari2600", new ArrayList {"bin", "a26", "rom", "gz"}},
                    {"lynx", new ArrayList {"lnx"}},
                    {"gamegear", new ArrayList {"gg"}},
                    {"ngp", new ArrayList {"ngp"}},
                    {"ngc", new ArrayList {"ngc"}},
                    {"pcengine", new ArrayList {"pce", "cue"}},
                    {"z-machine", new ArrayList {"dat", "z1", "z2", "z3", "z4", "z5", "z6", "z7", "z8"}}
                };

            var emulators = new ArrayList();
            foreach (var c in gbEmulator.Controls.OfType<CheckBox>().Where(x => x.Checked))
            {
                emulators.Add(c.Text.Replace(" ", string.Empty).ToLower());
            }

            foreach (string emu in emulators)
            foreach (var ext in extensions[emu])
            {
                var roms = Directory.GetFiles(reader, "*." + ext, SearchOption.AllDirectories);
                foreach (var rom in roms)
                {
                    p.Arguments = "a -tzip -mx9 -mm=Deflate64 " + $@"""{Path.ChangeExtension(rom, ".zip")}""" + " " + $@"""{rom}""";
                    var x = Process.Start(p);
                    x.WaitForExit();
                }
            }

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            txtDirectory.Text = RedudantHelper.Browse(txtDirectory.Text);
        }

        private void CompressRom_Load(object sender, EventArgs e)
        {
            ttDirectory.IsBalloon = true;
            ttef.IsBalloon = true;
            tte.IsBalloon = true;
            tte.SetToolTip(lbEmulator, "These systems have at least one emulator that supports zip files.");
            ttDirectory.SetToolTip(lbDirectory, "Put the root directory of the roms that will be zip'd.");
            ttef.SetToolTip(cbExtract,
                "Checking this will make it so files already ZIP'd will be extracted first to be zip'd up using 7-Zip's algorithm.");
        }
    }
}
