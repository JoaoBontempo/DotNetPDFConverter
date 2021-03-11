
namespace GoodTimePDFConverter
{
    partial class BarraProgresso
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlProgresso = new System.Windows.Forms.Panel();
            this.pnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Controls.Add(this.pnlProgresso);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(267, 33);
            this.pnlFundo.TabIndex = 0;
            // 
            // pnlProgresso
            // 
            this.pnlProgresso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProgresso.Location = new System.Drawing.Point(-1, 0);
            this.pnlProgresso.Name = "pnlProgresso";
            this.pnlProgresso.Size = new System.Drawing.Size(150, 33);
            this.pnlProgresso.TabIndex = 0;
            // 
            // BarraProgresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlFundo);
            this.Name = "BarraProgresso";
            this.Size = new System.Drawing.Size(267, 33);
            this.pnlFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlProgresso;
    }
}
