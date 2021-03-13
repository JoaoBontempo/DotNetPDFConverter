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
        #region Variaveis
        private int valor = 100, maximo = 100;
        private Color corFundo = Color.White, corProgresso = Color.Blue;
        #endregion

        #region Setters
        private void SetMaximo(int value)
        {
            SetValor(this.valor);
            if (value < this.valor)
            {
                SetValor(value);
                this.Valor = value;
            }
        }

        private void SetValor(int value)
        {
            if (value > this.Maximo)
            {
                value = this.Maximo;
                this.Valor = Maximo;
            }
            this.pnlProgresso.Size = new Size(((value * pnlFundo.Width)/this.Maximo)+1, this.Size.Height);
        }

        private void SetCorFundo(Color value)
        {
            this.pnlFundo.BackColor = value;
        }

        private void SetCorProgresso(Color value)
        {
            this.pnlProgresso.BackColor = value;
        }
        #endregion

        #region Propriedades
        [Category("Valores")]
        [Description("Valor máximo")]
        public int Maximo 
        {
            get 
            { 
                return this.maximo; 
            } 
            set 
            {
                this.maximo = value;
                SetMaximo(value);
            } 
        }

        [Category("Valores")]
        [Description("Porcentagem")]
        public float Porcentagem 
        {
            get
            {
                return (this.valor * 100) / this.maximo;
            }
        }

        [Category("Valores")]
        [Description("Valor de progresso")]
        [DefaultValue(10)]
        public int Valor
        {
            get 
            { 
                return this.valor; 
            }
            set
            {
                this.valor = value;
                SetValor(this.valor);
            }
        }
        
        [Category("Design")]
        [Description("Cor do progresso")]
        public Color CorProgresso
        {
            get { return this.corProgresso; }
            set
            { 
                if (value != null)
                    this.corProgresso = value;
                SetCorProgresso(this.corProgresso);
            }
        }

        [Category("Design")]
        [Description("Cor de fundo")]
        public Color CorFundo
        {
            get { return this.corFundo; }
            set
            {
                if (value != null)
                    this.corFundo = value;
                SetCorFundo(this.corFundo);
            }
        }
        #endregion

        public BarraProgresso()
        {
            InitializeComponent();
        }
    }
}
