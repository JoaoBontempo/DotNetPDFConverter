using GoodTimePDFConverter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodTimePDFConverter.Forms
{
    public partial class CaixaMensagemConversao : Form
    {
        public CaixaMensagemConversao(int totalFiles, int convertedFiles)
        {
            InitializeComponent();
            lbMensagem.Text = String.Format("{0} de {1} arquivos convertidos com sucesso!", convertedFiles, totalFiles);
            CentralizarLabel();
            foreach (Arquivo arquivo in Conversor.Arquivos)
            {
                string[] args = { arquivo.GetNome(), arquivo.GetTipo(), arquivo.GetStatus(), arquivo.GetMensagem() };
                dgvDetalhes.Rows.Add(args);
            }
        }

        private void CentralizarLabel()
        {
            int x = (this.Size.Width - lbMensagem.Size.Width) / 2;
            lbMensagem.Location = new Point(x, 22);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbDetalhes_Click(object sender, EventArgs e)
        {
            if (lbDetalhes.Text.Equals("Ver detalhes"))
            {
                this.Size = new Size(511, 360);
                lbDetalhes.Text = "Ocultar detalhes";
            }
            else
            { 
                this.Size = new Size(511, 128);
                lbDetalhes.Text = "Ver detalhes";
            }
        }
    }
}
