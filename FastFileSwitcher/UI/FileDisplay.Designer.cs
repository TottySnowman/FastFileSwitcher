using System.Windows.Forms;

namespace FastFileSwitcher.UI
{
    partial class FileDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFilename = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilename.Location = new System.Drawing.Point(3, 9);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(44, 16);
            this.labelFilename.TabIndex = 0;
            this.labelFilename.Text = "label1";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(3, 37);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(35, 13);
            this.labelFilePath.TabIndex = 1;
            this.labelFilePath.Text = "label1";
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveFile.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveFile.Location = new System.Drawing.Point(605, 6);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(26, 26);
            this.btnRemoveFile.TabIndex = 2;
            this.btnRemoveFile.Text = "X";
            this.btnRemoveFile.UseVisualStyleBackColor = false;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // FileDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.labelFilename);
            this.Name = "FileDisplay";
            this.Size = new System.Drawing.Size(641, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label labelFilePath;
        private Button btnRemoveFile;
    }
}
