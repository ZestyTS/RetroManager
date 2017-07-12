namespace RetroManager
{
    partial class CompressRom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lbDirectory = new System.Windows.Forms.Label();
            this.cbExtract = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbn64 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(281, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(61, 20);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(15, 34);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(260, 20);
            this.txtDirectory.TabIndex = 8;
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
            this.cbExtract.Location = new System.Drawing.Point(21, 273);
            this.cbExtract.Name = "cbExtract";
            this.cbExtract.Size = new System.Drawing.Size(81, 17);
            this.cbExtract.TabIndex = 10;
            this.cbExtract.Text = "Extract First";
            this.cbExtract.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
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
            this.cbn64.TabIndex = 12;
            this.cbn64.Text = "N64";
            this.cbn64.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbgg);
            this.groupBox1.Controls.Add(this.cbpc);
            this.groupBox1.Controls.Add(this.cbngp);
            this.groupBox1.Controls.Add(this.cbz);
            this.groupBox1.Controls.Add(this.cbngc);
            this.groupBox1.Controls.Add(this.cblynx);
            this.groupBox1.Controls.Add(this.cbatari);
            this.groupBox1.Controls.Add(this.cbms);
            this.groupBox1.Controls.Add(this.cbds);
            this.groupBox1.Controls.Add(this.cb32x);
            this.groupBox1.Controls.Add(this.cbsg);
            this.groupBox1.Controls.Add(this.cbgen);
            this.groupBox1.Controls.Add(this.cbgbc);
            this.groupBox1.Controls.Add(this.cbgb);
            this.groupBox1.Controls.Add(this.cbgba);
            this.groupBox1.Controls.Add(this.cbSnes);
            this.groupBox1.Controls.Add(this.cbNes);
            this.groupBox1.Controls.Add(this.cbn64);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 183);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emulators";
            // 
            // cbgg
            // 
            this.cbgg.AutoSize = true;
            this.cbgg.Location = new System.Drawing.Point(73, 108);
            this.cbgg.Name = "cbgg";
            this.cbgg.Size = new System.Drawing.Size(80, 17);
            this.cbgg.TabIndex = 30;
            this.cbgg.Text = "Game Gear";
            this.cbgg.UseVisualStyleBackColor = true;
            // 
            // cbpc
            // 
            this.cbpc.AutoSize = true;
            this.cbpc.Location = new System.Drawing.Point(237, 95);
            this.cbpc.Name = "cbpc";
            this.cbpc.Size = new System.Drawing.Size(84, 17);
            this.cbpc.TabIndex = 29;
            this.cbpc.Text = "PC Machine";
            this.cbpc.UseVisualStyleBackColor = true;
            // 
            // cbngp
            // 
            this.cbngp.AutoSize = true;
            this.cbngp.Location = new System.Drawing.Point(181, 131);
            this.cbngp.Name = "cbngp";
            this.cbngp.Size = new System.Drawing.Size(49, 17);
            this.cbngp.TabIndex = 28;
            this.cbngp.Text = "NGP";
            this.cbngp.UseVisualStyleBackColor = true;
            // 
            // cbz
            // 
            this.cbz.AutoSize = true;
            this.cbz.Location = new System.Drawing.Point(237, 72);
            this.cbz.Name = "cbz";
            this.cbz.Size = new System.Drawing.Size(77, 17);
            this.cbz.TabIndex = 27;
            this.cbz.Text = "Z-Machine";
            this.cbz.UseVisualStyleBackColor = true;
            // 
            // cbngc
            // 
            this.cbngc.AutoSize = true;
            this.cbngc.Location = new System.Drawing.Point(181, 154);
            this.cbngc.Name = "cbngc";
            this.cbngc.Size = new System.Drawing.Size(49, 17);
            this.cbngc.TabIndex = 26;
            this.cbngc.Text = "NGC";
            this.cbngc.UseVisualStyleBackColor = true;
            // 
            // cblynx
            // 
            this.cblynx.AutoSize = true;
            this.cblynx.Location = new System.Drawing.Point(181, 39);
            this.cblynx.Name = "cblynx";
            this.cblynx.Size = new System.Drawing.Size(48, 17);
            this.cblynx.TabIndex = 25;
            this.cblynx.Text = "Lynx";
            this.cblynx.UseVisualStyleBackColor = true;
            // 
            // cbatari
            // 
            this.cbatari.AutoSize = true;
            this.cbatari.Location = new System.Drawing.Point(181, 16);
            this.cbatari.Name = "cbatari";
            this.cbatari.Size = new System.Drawing.Size(74, 17);
            this.cbatari.TabIndex = 24;
            this.cbatari.Text = "Atari 2600";
            this.cbatari.UseVisualStyleBackColor = true;
            // 
            // cbms
            // 
            this.cbms.AutoSize = true;
            this.cbms.Location = new System.Drawing.Point(73, 85);
            this.cbms.Name = "cbms";
            this.cbms.Size = new System.Drawing.Size(95, 17);
            this.cbms.TabIndex = 22;
            this.cbms.Text = "Master System";
            this.cbms.UseVisualStyleBackColor = true;
            // 
            // cbds
            // 
            this.cbds.AutoSize = true;
            this.cbds.Location = new System.Drawing.Point(6, 154);
            this.cbds.Name = "cbds";
            this.cbds.Size = new System.Drawing.Size(41, 17);
            this.cbds.TabIndex = 21;
            this.cbds.Text = "DS";
            this.cbds.UseVisualStyleBackColor = true;
            // 
            // cb32x
            // 
            this.cb32x.AutoSize = true;
            this.cb32x.Location = new System.Drawing.Point(73, 39);
            this.cb32x.Name = "cb32x";
            this.cb32x.Size = new System.Drawing.Size(45, 17);
            this.cb32x.TabIndex = 20;
            this.cb32x.Text = "32X";
            this.cb32x.UseVisualStyleBackColor = true;
            // 
            // cbsg
            // 
            this.cbsg.AutoSize = true;
            this.cbsg.Location = new System.Drawing.Point(73, 16);
            this.cbsg.Name = "cbsg";
            this.cbsg.Size = new System.Drawing.Size(68, 17);
            this.cbsg.TabIndex = 19;
            this.cbsg.Text = "SG-1000";
            this.cbsg.UseVisualStyleBackColor = true;
            // 
            // cbgen
            // 
            this.cbgen.AutoSize = true;
            this.cbgen.Location = new System.Drawing.Point(73, 62);
            this.cbgen.Name = "cbgen";
            this.cbgen.Size = new System.Drawing.Size(64, 17);
            this.cbgen.TabIndex = 18;
            this.cbgen.Text = "Genesis";
            this.cbgen.UseVisualStyleBackColor = true;
            // 
            // cbgbc
            // 
            this.cbgbc.AutoSize = true;
            this.cbgbc.Location = new System.Drawing.Point(6, 108);
            this.cbgbc.Name = "cbgbc";
            this.cbgbc.Size = new System.Drawing.Size(48, 17);
            this.cbgbc.TabIndex = 17;
            this.cbgbc.Text = "GBC";
            this.cbgbc.UseVisualStyleBackColor = true;
            // 
            // cbgb
            // 
            this.cbgb.AutoSize = true;
            this.cbgb.Location = new System.Drawing.Point(6, 85);
            this.cbgb.Name = "cbgb";
            this.cbgb.Size = new System.Drawing.Size(41, 17);
            this.cbgb.TabIndex = 16;
            this.cbgb.Text = "GB";
            this.cbgb.UseVisualStyleBackColor = true;
            // 
            // cbgba
            // 
            this.cbgba.AutoSize = true;
            this.cbgba.Location = new System.Drawing.Point(6, 131);
            this.cbgba.Name = "cbgba";
            this.cbgba.Size = new System.Drawing.Size(48, 17);
            this.cbgba.TabIndex = 15;
            this.cbgba.Text = "GBA";
            this.cbgba.UseVisualStyleBackColor = true;
            // 
            // cbSnes
            // 
            this.cbSnes.AutoSize = true;
            this.cbSnes.Location = new System.Drawing.Point(6, 39);
            this.cbSnes.Name = "cbSnes";
            this.cbSnes.Size = new System.Drawing.Size(55, 17);
            this.cbSnes.TabIndex = 14;
            this.cbSnes.Text = "SNES";
            this.cbSnes.UseVisualStyleBackColor = true;
            // 
            // cbNes
            // 
            this.cbNes.AutoSize = true;
            this.cbNes.Location = new System.Drawing.Point(6, 16);
            this.cbNes.Name = "cbNes";
            this.cbNes.Size = new System.Drawing.Size(48, 17);
            this.cbNes.TabIndex = 13;
            this.cbNes.Text = "NES";
            this.cbNes.UseVisualStyleBackColor = true;
            // 
            // CompressRom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbExtract);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lbDirectory);
            this.Name = "CompressRom";
            this.Text = "CompressRom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label lbDirectory;
        private System.Windows.Forms.CheckBox cbExtract;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbn64;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSnes;
        private System.Windows.Forms.CheckBox cbNes;
        private System.Windows.Forms.CheckBox cbds;
        private System.Windows.Forms.CheckBox cb32x;
        private System.Windows.Forms.CheckBox cbsg;
        private System.Windows.Forms.CheckBox cbgen;
        private System.Windows.Forms.CheckBox cbgbc;
        private System.Windows.Forms.CheckBox cbgb;
        private System.Windows.Forms.CheckBox cbgba;
        private System.Windows.Forms.CheckBox cbgg;
        private System.Windows.Forms.CheckBox cbpc;
        private System.Windows.Forms.CheckBox cbngp;
        private System.Windows.Forms.CheckBox cbz;
        private System.Windows.Forms.CheckBox cbngc;
        private System.Windows.Forms.CheckBox cblynx;
        private System.Windows.Forms.CheckBox cbatari;
        private System.Windows.Forms.CheckBox cbms;
    }
}