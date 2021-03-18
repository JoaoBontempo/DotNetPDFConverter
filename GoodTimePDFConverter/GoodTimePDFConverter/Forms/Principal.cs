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
        private int converted = 0, cont = 0;
        private bool cancel;
        public Principal()
        {
            InitializeComponent();
        }

        private bool ArquivoJaSelecionado(string path)
        {
            foreach (FileInterface file in flpFiles.Controls)
            {
                if (file.file.FullName.Equals(path))
                {
                    MessageBox.Show(String.Format("O arquivo {0} já está selecionado", file.file.Name));
                    return true;
                }
            }
            return false;
        }

        private void btnNovoArquivo_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK.Equals(ofdSelectFile.ShowDialog()))
            {
                foreach(string path in ofdSelectFile.FileNames)
                {
                    if (ArquivoJaSelecionado(path))
                        continue;
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
            if (visible)
                this.Size = new Size(394, 512);
            else
                this.Size = new Size(394, 460);
            
            lbLoading.Visible = visible;
            pbxLoading.Visible = visible;
            pbarProgresso.Visible = visible;
            lbPorcentagem.Visible = visible;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (btnConverter.Tag.Equals("Convert"))
            {
                if (VerificarCampos())
                {
                    if (!bwConversor.IsBusy)
                    {
                        cancel = false;
                        converted = 0;
                        pbarProgresso.Valor = 0;
                        pbarProgresso.Maximo = flpFiles.Controls.Count;
                        LoadingVisible(true);
                        cont = 0;
                        bwConversor.RunWorkerAsync();
                        btnConverter.Tag = "Cancel";
                        btnConverter.Text = "Cancelar conversão";
                    }
                    else
                    {
                        MessageBox.Show("Não é possível converter os arquivos pois existem arquivos na fila.");
                    }
                }
            }
            else
            {
                bwConversor.CancelAsync();
                lbLoading.Text = "Cancelando conversão...";
                btnConverter.Tag = "Convert";
                btnConverter.Text = "Converter arquivos";
                cancel = true;
            }
        }

        private void bwConversor_DoWork(object sender, DoWorkEventArgs e)
        {
            Conversor.Arquivos.Clear();
            object[] infos = new object[2];
            converted = 0;
            foreach (FileInterface file in flpFiles.Controls)
            {
                if (!bwConversor.CancellationPending)
                {
                    infos[0] = file.file.Name;
                    infos[1] = true;
                    bwConversor.ReportProgress(converted, infos);
                    if (Conversor.FileToPDF(file, txtOutputPath.Text))
                        cont++;
                    infos[1] = false;
                    converted++;
                    bwConversor.ReportProgress(converted, infos);
                }
                else
                {
                    return;
                }
            }
        }

        private string FormatarLabel(Label label)
        {
            string newText = "";
            foreach (char caracter in label.Text)
            {
                newText += caracter;
                Size tamanho = TextRenderer.MeasureText(newText, label.Font);
                if (tamanho.Width > 265)
                {
                    newText += "(...)";
                    return newText;
                }
            }
            return newText;
        }

        private void bwConversor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object[] infos = (object[])e.UserState;
            if (Convert.ToBoolean(infos[1]))
            {
                lbLoading.Text = "Convertendo: " + infos[0].ToString();
                lbLoading.Text = FormatarLabel(lbLoading);
            }
            pbarProgresso.Valor = e.ProgressPercentage;
            lbPorcentagem.Text = Convert.ToInt32(pbarProgresso.Porcentagem).ToString() + "%";
        }

        private void bwConversor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (cancel)
            {
                LoadingVisible(false);
                MessageBox.Show("Conversão cancelada com sucesso!");
                return;
            }
            LoadingVisible(false);
            if (cont != 0)
            {
                lbLoading.Text = "Arquivos convertidos com sucesso.";
                btnConverter.Tag = "Convert";
                btnConverter.Text = "Converter arquivos";
                CaixaMensagemConversao cmc = new CaixaMensagemConversao(flpFiles.Controls.Count, cont);
                cmc.ShowDialog();
            }
        }

        private void lbReset_Click(object sender, EventArgs e)
        {
            if (!bwConversor.IsBusy)
            {
                flpFiles.Controls.Clear();
                txtOutputPath.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Não é possível limpar os dados quando os arquivos estão sendo convertidos");
            }
        }
    }
}
