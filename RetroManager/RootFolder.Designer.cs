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
            this.components = new System.ComponentModel.Container();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lbDirectory = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.cbRename = new System.Windows.Forms.CheckBox();
            this.ttDirectory = new System.Windows.Forms.ToolTip(this.components);
            this.ttR = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(281, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(61, 20);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(15, 41);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(260, 20);
            this.txtDirectory.TabIndex = 1;
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
            this.btnMove.Location = new System.Drawing.Point(15, 127);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // cbRename
            // 
            this.cbRename.AutoSize = true;
            this.cbRename.Location = new System.Drawing.Point(15, 95);
            this.cbRename.Name = "cbRename";
            this.cbRename.Size = new System.Drawing.Size(129, 17);
            this.cbRename.TabIndex = 3;
            this.cbRename.Text = "Rename File to Folder";
            this.cbRename.UseVisualStyleBackColor = true;
            // 
            // RootFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 167);
            this.Controls.Add(this.cbRename);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lbDirectory);
            this.Name = "RootFolder";
            this.Text = "RootFolder";
            this.Load += new System.EventHandler(this.RootFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label lbDirectory;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.CheckBox cbRename;
        private System.Windows.Forms.ToolTip ttDirectory;
        private System.Windows.Forms.ToolTip ttR;
    }
}