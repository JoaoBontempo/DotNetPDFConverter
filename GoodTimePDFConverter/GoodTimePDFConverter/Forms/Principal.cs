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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnNovoArquivo_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK.Equals(ofdSelectFile.ShowDialog()))
            {
                foreach(string path in ofdSelectFile.FileNames)
                {
                    FileInfo file = new FileInfo(path);
                    if (!file.Extension.Contains("xls") && !file.Extension.Contains("doc"))
                    {
                        MessageBox.Show(String.Format("O arquivo '{0}' não está em um formato correto\n" +
                            "\n*Apenas arquivos do word (.docx) e excel (.xlsx) podem ser convertidos", file.Name), "Extensão inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    FileInterface fileInterface = new FileInterface(path, this);
                    flpFiles.Controls.Add(fileInterface);
                }
            }

        }

        private void btnSelecionarOutput_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK.Equals(fbdOutputPath.ShowDialog()))
            {
                txtOutputPath.Text = fbdOutputPath.SelectedPath;
            }
        }

    }
}
