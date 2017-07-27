using System.ComponentModel;
using System.Windows.Forms;

namespace RetroManager
{
    partial class MainMenu
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
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnRevision = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnFolderMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegion
            // 
            this.btnRegion.Location = new System.Drawing.Point(12, 12);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(229, 23);
            this.btnRegion.TabIndex = 0;
            this.btnRegion.Text = "Region Duplicate";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.BtnRegion_Click);
            // 
            // btnRevision
            // 
            this.btnRevision.Location = new System.Drawing.Point(12, 59);
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.Size = new System.Drawing.Size(229, 23);
            this.btnRevision.TabIndex = 1;
            this.btnRevision.Text = "Revision Duplicate";
            this.btnRevision.UseVisualStyleBackColor = true;
            this.btnRevision.Click += new System.EventHandler(this.BtnRevision_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(12, 106);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(229, 23);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "Compress Roms";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.BtnCompress_Click);
            // 
            // btnFolderMove
            // 
            this.btnFolderMove.Location = new System.Drawing.Point(12, 155);
            this.btnFolderMove.Name = "btnFolderMove";
            this.btnFolderMove.Size = new System.Drawing.Size(229, 23);
            this.btnFolderMove.TabIndex = 3;
            this.btnFolderMove.Text = "Move Roms to Root Folder";
            this.btnFolderMove.UseVisualStyleBackColor = true;
            this.btnFolderMove.Click += new System.EventHandler(this.BtnFolderMove_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 192);
            this.Controls.Add(this.btnFolderMove);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnRevision);
            this.Controls.Add(this.btnRegion);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegion;
        private Button btnRevision;
        private Button btnCompress;
        private Button btnFolderMove;
    }
}

