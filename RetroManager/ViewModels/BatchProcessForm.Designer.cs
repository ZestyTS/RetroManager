using System.ComponentModel;
using System.Windows.Forms;

namespace RetroManager
{
    partial class BatchProcessForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.cbRevision = new System.Windows.Forms.CheckBox();
            this.cbRegion = new System.Windows.Forms.CheckBox();
            this.cbCompress = new System.Windows.Forms.CheckBox();
            this.cbRootRoms = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 124);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(229, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // cbRevision
            // 
            this.cbRevision.AutoSize = true;
            this.cbRevision.Location = new System.Drawing.Point(12, 39);
            this.cbRevision.Name = "cbRevision";
            this.cbRevision.Size = new System.Drawing.Size(115, 17);
            this.cbRevision.TabIndex = 8;
            this.cbRevision.Text = "Revision Duplicate";
            this.cbRevision.UseVisualStyleBackColor = true;
            // 
            // cbRegion
            // 
            this.cbRegion.AutoSize = true;
            this.cbRegion.Location = new System.Drawing.Point(12, 16);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(108, 17);
            this.cbRegion.TabIndex = 7;
            this.cbRegion.Text = "Region Duplicate";
            this.cbRegion.UseVisualStyleBackColor = true;
            // 
            // cbCompress
            // 
            this.cbCompress.AutoSize = true;
            this.cbCompress.Location = new System.Drawing.Point(12, 62);
            this.cbCompress.Name = "cbCompress";
            this.cbCompress.Size = new System.Drawing.Size(102, 17);
            this.cbCompress.TabIndex = 9;
            this.cbCompress.Text = "Compress Roms";
            this.cbCompress.UseVisualStyleBackColor = true;
            // 
            // cbRootRoms
            // 
            this.cbRootRoms.AutoSize = true;
            this.cbRootRoms.Location = new System.Drawing.Point(12, 85);
            this.cbRootRoms.Name = "cbRootRoms";
            this.cbRootRoms.Size = new System.Drawing.Size(121, 17);
            this.cbRootRoms.TabIndex = 10;
            this.cbRootRoms.Text = "Move Roms to Root";
            this.cbRootRoms.UseVisualStyleBackColor = true;
            // 
            // BatchProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 161);
            this.Controls.Add(this.cbRootRoms);
            this.Controls.Add(this.cbCompress);
            this.Controls.Add(this.cbRevision);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchProcessForm";
            this.Text = "Batch Process";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSubmit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private CheckBox cbRevision;
        private CheckBox cbRegion;
        private CheckBox cbRootRoms;
        private CheckBox cbCompress;
    }
}

