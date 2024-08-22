using FastFileSwitcher.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace FastFileSwitcher.UI
{
    public partial class DisplayFiles : Form
    {
        public DisplayFiles(IEnumerable<File> switcherList)
        {
            InitializeComponent();
            for (int x = 0; x < switcherList.Count(); x++)
            {
                var file = switcherList.ElementAt(x);
                if (file == null)
                {
                    continue;
                }

                var fileDisplay = new FileDisplay()
                {
                    FilenameText = file.FileName,
                    FilePathText = file.FilePath,
                    FileSlot = x
                };

                fileDisplay.Margin = new Padding(2);  // Add some margin between controls

                flowLayoutPanel1.Controls.Add(fileDisplay);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
