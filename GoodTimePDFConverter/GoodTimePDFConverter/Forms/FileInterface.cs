using GoodTimePDFConverter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodTimePDFConverter.Forms
{
    public partial class FileInterface : UserControl
    {
        public FileInfo file;
        private Principal menu;
        public FileInterface(string path, Principal menu)
        {
            file = new FileInfo(path);
            this.menu = menu;
            InitializeComponent();
            pbxFileIcon.Image = file.Extension.Contains("doc") ? Resources.word : Resources.excel;
            lbFileName.Text = file.Name;
            if (lbFileName.Width > 240)
            {
                lbFileName.Text = String.Empty;
                foreach (char caracter in file.Name)
                {
                    lbFileName.Text += caracter;
                    if (lbFileName.Width > 240)
                    {
                        lbFileName.Text += "(...)";
                        break;
                    }
                }
            }
        }

        private void btnRemoverArquivo_Click(object sender, EventArgs e)
        {
            menu.flpFiles.Controls.Remove(this);
        }
    }
}
