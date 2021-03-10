using GoodTimePDFConverter.Classes;
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
        private static ArrayList errorFiles = new ArrayList();
        private static int converted = 0;
        private static FlowLayoutPanel panelFiles;
        private static ProgressBar barraProgresso;
        private static Label labelProgresso;
        private static string path;
        Thread ConverterArquivos = new Thread(ConverterArquivosPDF);

        public Principal()
        {
            InitializeComponent();
            panelFiles = flpFiles;
            labelProgresso = lbConvertProgress;
            barraProgresso = pbarConvertProgress;
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

        private static void ConverterArquivosPDF()
        {
            barraProgresso.Value = 0;
            barraProgresso.Maximum = panelFiles.Controls.Count;
            errorFiles.Clear();
            foreach (FileInterface file in panelFiles.Controls)
            {
                labelProgresso.Text = String.Format("Convertendo o arquivo {0}...", file.file.Name);
                if (Conversor.FileToPDF(file, path))
                {
                    barraProgresso.Value++;
                    converted++;
                }
                else
                {
                    labelProgresso.Text = String.Format("Ocorreu um erro ao converter o arquivo {0}...", file.file.Name);
                    errorFiles.Add(file);
                }
            }
            barraProgresso.Value = 0;
            labelProgresso.Text = String.Format("{0}  ");
            if (converted == panelFiles.Controls.Count)
                MessageBox.Show(String.Format("{0} arquivo(s) foram convertidos para PDF com sucesso e não houve nenhuma falha!"));
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

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                ConverterArquivos.Start();
                MessageBox.Show("Arquivos convertidos com sucesso!");
            }
        }
    }
}
