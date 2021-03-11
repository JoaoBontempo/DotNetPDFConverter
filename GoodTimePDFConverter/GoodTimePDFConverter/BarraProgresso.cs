using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodTimePDFConverter
{
    public partial class BarraProgresso : UserControl
    {
        public int Valor 
        {
            get { return this.Valor; }
            set { pnlProgresso.Size = new Size(pnlFundo.Height, (value * pnlFundo.Width) / this.Maximo); } 
        }
        public int Maximo { get; set; }
        public Color CorProgresso 
        {
            get { return this.CorProgresso; }
            set { this.pnlProgresso.BackColor = value; } 
        }
        public Color CorFundo { get; set; }

        public BarraProgresso()
        {
            InitializeComponent();
        }
    }
}
