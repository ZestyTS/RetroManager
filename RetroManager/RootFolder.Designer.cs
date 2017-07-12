namespace RetroManager
{
    partial class RootFolder
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
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(281, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(61, 20);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(15, 41);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(260, 20);
            this.txtDirectory.TabIndex = 8;
            // 
            // lbDirectory
            // 
            this.lbDirectory.AutoSize = true;
            this.lbDirectory.Location = new System.Drawing.Point(12, 25);
            this.lbDirectory.Name = "lbDirectory";
            this.lbDirectory.Size = new System.Drawing.Size(62, 13);
            this.lbDirectory.TabIndex = 7;
            this.lbDirectory.Text = "Root Folder";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(12, 107);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 10;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // RootFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 261);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lbDirectory);
            this.Name = "RootFolder";
            this.Text = "RootFolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label lbDirectory;
        private System.Windows.Forms.Button btnMove;
    }
}