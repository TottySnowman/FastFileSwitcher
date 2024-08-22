using FastFileSwitcher.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFileSwitcher.UI
{
    public partial class FileDisplay : UserControl
    {
        public FileDisplay()
        {
            InitializeComponent();
        }

        public string FilenameText
        {
            get { return labelFilename.Text; }
            set { labelFilename.Text = value; }
        }

        public string FilePathText
        {
            get { return labelFilePath.Text; }
            set { labelFilePath.Text = value; }
        }

        public int FileSlot { get; set; }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            FileManager.Instance.RemoveFile(FileSlot);
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}
