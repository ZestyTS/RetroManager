using System.ComponentModel;
using System.Windows.Forms;

namespace RetroManager
{
    partial class CompressRomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
            this.components = new System.ComponentModel.Container();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lbDirectory = new System.Windows.Forms.Label();
            this.cbExtract = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbn64 = new System.Windows.Forms.CheckBox();
            this.gbEmulator = new System.Windows.Forms.GroupBox();
            this.lbEmulator = new System.Windows.Forms.Label();
            this.cbgg = new System.Windows.Forms.CheckBox();
            this.cbpc = new System.Windows.Forms.CheckBox();
            this.cbngp = new System.Windows.Forms.CheckBox();
            this.cbz = new System.Windows.Forms.CheckBox();
            this.cbngc = new System.Windows.Forms.CheckBox();
            this.cblynx = new System.Windows.Forms.CheckBox();
            this.cbatari = new System.Windows.Forms.CheckBox();
            this.cbms = new System.Windows.Forms.CheckBox();
            this.cbds = new System.Windows.Forms.CheckBox();
            this.cb32x = new System.Windows.Forms.CheckBox();
            this.cbsg = new System.Windows.Forms.CheckBox();
            this.cbgen = new System.Windows.Forms.CheckBox();
            this.cbgbc = new System.Windows.Forms.CheckBox();
            this.cbgb = new System.Windows.Forms.CheckBox();
            this.cbgba = new System.Windows.Forms.CheckBox();
            this.cbSnes = new System.Windows.Forms.CheckBox();
            this.cbNes = new System.Windows.Forms.CheckBox();
            this.ttDirectory = new System.Windows.Forms.ToolTip(this.components);
            this.ttef = new System.Windows.Forms.ToolTip(this.components);
            this.tte = new System.Windows.Forms.ToolTip(this.components);
            this.pb = new System.Windows.Forms.ProgressBar();
            this.radZip = new System.Windows.Forms.RadioButton();
			this.rad7z = new System.Windows.Forms.RadioButton();
			this.lbExport = new System.Windows.Forms.Label();
            this.gbEmulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(281, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(61, 24);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(15, 33);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(260, 20);
            this.txtDirectory.TabIndex = 1;
            // 
            // lbDirectory
            // 
            this.lbDirectory.AutoSize = true;
            this.lbDirectory.Location = new System.Drawing.Point(12, 18);
            this.lbDirectory.Name = "lbDirectory";
            this.lbDirectory.Size = new System.Drawing.Size(49, 13);
            this.lbDirectory.TabIndex = 7;
            this.lbDirectory.Text = "Directory";
            // 
            // cbExtract
            // 
            this.cbExtract.AutoSize = true;
            this.cbExtract.Location = new System.Drawing.Point(21, 70);
            this.cbExtract.Name = "cbExtract";
            this.cbExtract.Size = new System.Drawing.Size(81, 17);
            this.cbExtract.TabIndex = 21;
            this.cbExtract.Text = "Extract Archives First";
            this.cbExtract.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 315);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // cbn64
            // 
            this.cbn64.AutoSize = true;
            this.cbn64.Location = new System.Drawing.Point(6, 62);
            this.cbn64.Name = "cbn64";
            this.cbn64.Size = new System.Drawing.Size(46, 17);
            this.cbn64.TabIndex = 5;
            this.cbn64.Text = "N64";
            this.cbn64.UseVisualStyleBackColor = true;
            // 
            // gbEmulator
            // 
            this.gbEmulator.Controls.Add(this.lbEmulator);
            this.gbEmulator.Controls.Add(this.cbgg);
            this.gbEmulator.Controls.Add(this.cbpc);
            this.gbEmulator.Controls.Add(this.cbngp);
            this.gbEmulator.Controls.Add(this.cbz);
            this.gbEmulator.Controls.Add(this.cbngc);
            this.gbEmulator.Controls.Add(this.cblynx);
            this.gbEmulator.Controls.Add(this.cbatari);
            this.gbEmulator.Controls.Add(this.cbms);
            this.gbEmulator.Controls.Add(this.cbds);
            this.gbEmulator.Controls.Add(this.cb32x);
            this.gbEmulator.Controls.Add(this.cbsg);
            this.gbEmulator.Controls.Add(this.cbgen);
            this.gbEmulator.Controls.Add(this.cbgbc);
            this.gbEmulator.Controls.Add(this.cbgb);
            this.gbEmulator.Controls.Add(this.cbgba);
            this.gbEmulator.Controls.Add(this.cbSnes);
            this.gbEmulator.Controls.Add(this.cbNes);
            this.gbEmulator.Controls.Add(this.cbn64);
            this.gbEmulator.Location = new System.Drawing.Point(15, 95);
            this.gbEmulator.Name = "gbEmulator";
            this.gbEmulator.Size = new System.Drawing.Size(327, 183);
            this.gbEmulator.TabIndex = 13;
            this.gbEmulator.TabStop = false;
            // 
            // lbEmulator
            // 
            this.lbEmulator.AutoSize = true;
            this.lbEmulator.Location = new System.Drawing.Point(6, 0);
            this.lbEmulator.Name = "lbEmulator";
            this.lbEmulator.Size = new System.Drawing.Size(53, 13);
            this.lbEmulator.TabIndex = 14;
            this.lbEmulator.Text = "Emulators";
            // 
            // cbgg
            // 
            this.cbgg.AutoSize = true;
            this.cbgg.Location = new System.Drawing.Point(85, 108);
            this.cbgg.Name = "cbgg";
            this.cbgg.Size = new System.Drawing.Size(80, 17);
            this.cbgg.TabIndex = 14;
            this.cbgg.Text = "Game Gear";
            this.cbgg.UseVisualStyleBackColor = true;
            // 
            // cbpc
            // 
            this.cbpc.AutoSize = true;
            this.cbpc.Location = new System.Drawing.Point(198, 85);
            this.cbpc.Name = "cbpc";
            this.cbpc.Size = new System.Drawing.Size(49, 17);
            this.cbpc.TabIndex = 20;
            this.cbpc.Text = "PC Machine";
            this.cbpc.UseVisualStyleBackColor = true;
            // 
            // cbngp
            // 
            this.cbngp.AutoSize = true;
            this.cbngp.Location = new System.Drawing.Point(85, 131);
            this.cbngp.Name = "cbngp";
            this.cbngp.Size = new System.Drawing.Size(49, 17);
            this.cbngp.TabIndex = 17;
            this.cbngp.Text = "NGP";
            this.cbngp.UseVisualStyleBackColor = true;
            // 
            // cbz
            // 
            this.cbz.AutoSize = true;
            this.cbz.Location = new System.Drawing.Point(198, 62);
            this.cbz.Name = "cbz";
            this.cbz.Size = new System.Drawing.Size(49, 17);
            this.cbz.TabIndex = 19;
            this.cbz.Text = "Z-Machine";
            this.cbz.UseVisualStyleBackColor = true;
            // 
            // cbngc
            // 
            this.cbngc.AutoSize = true;
            this.cbngc.Location = new System.Drawing.Point(85, 154);
            this.cbngc.Name = "cbngc";
            this.cbngc.Size = new System.Drawing.Size(49, 17);
            this.cbngc.TabIndex = 18;
            this.cbngc.Text = "NGC";
            this.cbngc.UseVisualStyleBackColor = true;
            // 
            // cblynx
            // 
            this.cblynx.AutoSize = true;
            this.cblynx.Location = new System.Drawing.Point(198, 39);
            this.cblynx.Name = "cblynx";
            this.cblynx.Size = new System.Drawing.Size(48, 17);
            this.cblynx.TabIndex = 16;
            this.cblynx.Text = "Lynx";
            this.cblynx.UseVisualStyleBackColor = true;
            // 
            // cbatari
            // 
            this.cbatari.AutoSize = true;
            this.cbatari.Location = new System.Drawing.Point(198, 16);
            this.cbatari.Name = "cbatari";
            this.cbatari.Size = new System.Drawing.Size(74, 17);
            this.cbatari.TabIndex = 15;
            this.cbatari.Text = "Atari 2600";
            this.cbatari.UseVisualStyleBackColor = true;
            // 
            // cbms
            // 
            this.cbms.AutoSize = true;
            this.cbms.Location = new System.Drawing.Point(85, 85);
            this.cbms.Name = "cbms";
            this.cbms.Size = new System.Drawing.Size(95, 17);
            this.cbms.TabIndex = 13;
            this.cbms.Text = "Master System";
            this.cbms.UseVisualStyleBackColor = true;
            // 
            // cbds
            // 
            this.cbds.AutoSize = true;
            this.cbds.Location = new System.Drawing.Point(6, 154);
            this.cbds.Name = "cbds";
            this.cbds.Size = new System.Drawing.Size(41, 17);
            this.cbds.TabIndex = 9;
            this.cbds.Text = "DS";
            this.cbds.UseVisualStyleBackColor = true;
            // 
            // cb32x
            // 
            this.cb32x.AutoSize = true;
            this.cb32x.Location = new System.Drawing.Point(85, 39);
            this.cb32x.Name = "cb32x";
            this.cb32x.Size = new System.Drawing.Size(45, 17);
            this.cb32x.TabIndex = 11;
            this.cb32x.Text = "32X";
            this.cb32x.UseVisualStyleBackColor = true;
            // 
            // cbsg
            // 
            this.cbsg.AutoSize = true;
            this.cbsg.Location = new System.Drawing.Point(85, 16);
            this.cbsg.Name = "cbsg";
            this.cbsg.Size = new System.Drawing.Size(68, 17);
            this.cbsg.TabIndex = 10;
            this.cbsg.Text = "SG-1000";
            this.cbsg.UseVisualStyleBackColor = true;
            // 
            // cbgen
            // 
            this.cbgen.AutoSize = true;
            this.cbgen.Location = new System.Drawing.Point(85, 62);
            this.cbgen.Name = "cbgen";
            this.cbgen.Size = new System.Drawing.Size(64, 17);
            this.cbgen.TabIndex = 12;
            this.cbgen.Text = "Genesis";
            this.cbgen.UseVisualStyleBackColor = true;
            // 
            // cbgbc
            // 
            this.cbgbc.AutoSize = true;
            this.cbgbc.Location = new System.Drawing.Point(6, 108);
            this.cbgbc.Name = "cbgbc";
            this.cbgbc.Size = new System.Drawing.Size(48, 17);
            this.cbgbc.TabIndex = 7;
            this.cbgbc.Text = "GBC";
            this.cbgbc.UseVisualStyleBackColor = true;
            // 
            // cbgb
            // 
            this.cbgb.AutoSize = true;
            this.cbgb.Location = new System.Drawing.Point(6, 85);
            this.cbgb.Name = "cbgb";
            this.cbgb.Size = new System.Drawing.Size(41, 17);
            this.cbgb.TabIndex = 6;
            this.cbgb.Text = "GB";
            this.cbgb.UseVisualStyleBackColor = true;
            // 
            // cbgba
            // 
            this.cbgba.AutoSize = true;
            this.cbgba.Location = new System.Drawing.Point(6, 131);
            this.cbgba.Name = "cbgba";
            this.cbgba.Size = new System.Drawing.Size(48, 17);
            this.cbgba.TabIndex = 8;
            this.cbgba.Text = "GBA";
            this.cbgba.UseVisualStyleBackColor = true;
            // 
            // cbSnes
            // 
            this.cbSnes.AutoSize = true;
            this.cbSnes.Location = new System.Drawing.Point(6, 39);
            this.cbSnes.Name = "cbSnes";
            this.cbSnes.Size = new System.Drawing.Size(55, 17);
            this.cbSnes.TabIndex = 4;
            this.cbSnes.Text = "SNES";
            this.cbSnes.UseVisualStyleBackColor = true;
            // 
            // cbNes
            // 
            this.cbNes.AutoSize = true;
            this.cbNes.Location = new System.Drawing.Point(6, 16);
            this.cbNes.Name = "cbNes";
            this.cbNes.Size = new System.Drawing.Size(48, 17);
            this.cbNes.TabIndex = 3;
            this.cbNes.Text = "NES";
            this.cbNes.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(142, 285);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(200, 50);
            this.pb.TabIndex = 14;
			this.pb.Visible = false;
			// 
			// radZip
			// 
			this.radZip.Checked = true;
			this.radZip.AutoSize = true;
			this.radZip.Location = new System.Drawing.Point(61, 285);
			this.radZip.Name = "radZip";
			this.radZip.Size = new System.Drawing.Size(40, 20);
			this.radZip.TabIndex = 22;
			this.radZip.Text = "Zip";
			this.radZip.UseVisualStyleBackColor = true;
			// 
			// rad7z
			// 
			this.rad7z.AutoSize = true;
			this.rad7z.Location = new System.Drawing.Point(101, 285);
			this.rad7z.Name = "rad7z";
			this.rad7z.Size = new System.Drawing.Size(40, 20);
			this.rad7z.TabIndex = 23;
			this.rad7z.Text = "7z";
			this.rad7z.UseVisualStyleBackColor = true;
            // 
            // lbExport
            // 
            this.lbExport.AutoSize = true;
			this.lbExport.Location = new System.Drawing.Point(15, 287);
			this.lbExport.Name = "lbExport";
			this.lbExport.Size = new System.Drawing.Size(40, 20);
			this.lbExport.TabIndex = 14;
			this.lbExport.Text = "Export to";
            // 
            // CompressRom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 350);
			this.Controls.Add(this.rad7z);
			this.Controls.Add(this.radZip);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.gbEmulator);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbExtract);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectory);
			this.Controls.Add(this.lbDirectory);
			this.Controls.Add(this.lbExport);
            this.Name = "CompressRom";
            this.Text = "CompressRom";
            this.Load += new System.EventHandler(this.CompressRom_Load);
            this.gbEmulator.ResumeLayout(false);
            this.gbEmulator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBrowse;
        private TextBox txtDirectory;
        private Label lbDirectory;
        private CheckBox cbExtract;
        private Button btnStart;
        private CheckBox cbn64;
        private GroupBox gbEmulator;
        private CheckBox cbSnes;
        private CheckBox cbNes;
        private CheckBox cbds;
        private CheckBox cb32x;
        private CheckBox cbsg;
        private CheckBox cbgen;
        private CheckBox cbgbc;
        private CheckBox cbgb;
        private CheckBox cbgba;
        private CheckBox cbgg;
        private CheckBox cbpc;
        private CheckBox cbngp;
        private CheckBox cbz;
        private CheckBox cbngc;
        private CheckBox cblynx;
        private CheckBox cbatari;
        private CheckBox cbms;
        private ToolTip ttDirectory;
        private ToolTip ttef;
        private ToolTip tte;
		private Label lbEmulator;
		private Label lbExport;
        private ProgressBar pb;
        private RadioButton radZip;
        private RadioButton rad7z;
    }
}