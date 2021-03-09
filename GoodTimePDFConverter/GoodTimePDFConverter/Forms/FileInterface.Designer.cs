
namespace GoodTimePDFConverter.Forms
{
    partial class FileInterface
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
            this.btnRemoverArquivo = new System.Windows.Forms.Button();
            this.pbxFileIcon = new System.Windows.Forms.PictureBox();
            this.lbFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoverArquivo
            // 
            this.btnRemoverArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoverArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverArquivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverArquivo.ForeColor = System.Drawing.Color.White;
            this.btnRemoverArquivo.Location = new System.Drawing.Point(297, 2);
            this.btnRemoverArquivo.Name = "btnRemoverArquivo";
            this.btnRemoverArquivo.Size = new System.Drawing.Size(23, 23);
            this.btnRemoverArquivo.TabIndex = 9;
            this.btnRemoverArquivo.Text = "X";
            this.btnRemoverArquivo.UseVisualStyleBackColor = false;
            this.btnRemoverArquivo.Click += new System.EventHandler(this.btnRemoverArquivo_Click);
            // 
            // pbxFileIcon
            // 
            this.pbxFileIcon.Location = new System.Drawing.Point(4, 2);
            this.pbxFileIcon.Name = "pbxFileIcon";
            this.pbxFileIcon.Size = new System.Drawing.Size(23, 22);
            this.pbxFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFileIcon.TabIndex = 10;
            this.pbxFileIcon.TabStop = false;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(33, 5);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(125, 16);
            this.lbFileName.TabIndex = 11;
            this.lbFileName.Text = "FileName.Extension";
            // 
            // FileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxFileIcon);
            this.Controls.Add(this.btnRemoverArquivo);
            this.Controls.Add(this.lbFileName);
            this.Name = "FileInterface";
            this.Size = new System.Drawing.Size(326, 27);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoverArquivo;
        private System.Windows.Forms.Label lbFileName;
        public System.Windows.Forms.PictureBox pbxFileIcon;
    }
}
