using GoodTimePDFConverter.Classes;
using GoodTimePDFConverter.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodTimePDFConverter.Forms
{
    public partial class Principal : Form
    {
        private ArrayList errorFiles = new ArrayList();
        private int converted = 0, lastConverted = 0;
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

        private bool VerificarCampos()
        {
            if (String.IsNullOrEmpty(txtOutputPath.Text))
            {
                MessageBox.Show("Nenhum caminho de saída foi selecionado\n" +
                    "\n*O caminho de saída é o local em que seus arquivos convertidos em pdf serão salvos", "Selecione um caminho de saída", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelecionarOutput_Click(null, null);
                return false;
            }
            if (flpFiles.Controls.Count == 0)
            {
                MessageBox.Show("Nenhum arquivo foi selecionado para conversão", "Selecione ao menos um arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNovoArquivo_Click(null,null);
                return false;
            }
            return true;
        }

        private void LoadingVisible(bool visible)
        {
            lbLoading.Visible = visible;
            pbxLoading.Visible = visible;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            converted = 0;
            lastConverted = 0;
            pbarProgresso.Maximum = flpFiles.Controls.Count;
            barraProgresso2.Maximo = flpFiles.Controls.Count;
            if (VerificarCampos())
            {
                LoadingVisible(true);
                bwConversor.RunWorkerAsync();
            }
        }

        private void bwConversor_DoWork(object sender, DoWorkEventArgs e)
        {
            converted = 0;
            foreach (FileInterface file in flpFiles.Controls)
            {
                Conversor.FileToPDF(file, txtOutputPath.Text);
                converted++;
                bwConversor.ReportProgress(converted);
            }
        }

        private void bwConversor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbarProgresso.Value = e.ProgressPercentage;
            barraProgresso2.Valor = e.ProgressPercentage;
        }

        private void bwConversor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadingVisible(false);
            MessageBox.Show("Arquivos convertidos com sucesso!");
        }
    }
}
