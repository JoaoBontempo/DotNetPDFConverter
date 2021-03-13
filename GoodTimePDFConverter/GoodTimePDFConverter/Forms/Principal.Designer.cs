
namespace GoodTimePDFConverter.Forms
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovoArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnSelecionarOutput = new System.Windows.Forms.Button();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdOutputPath = new System.Windows.Forms.FolderBrowserDialog();
            this.lbLoading = new System.Windows.Forms.Label();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.bwConversor = new System.ComponentModel.BackgroundWorker();
            this.lbPorcentagem = new System.Windows.Forms.Label();
            this.pbarProgresso = new GoodTimePDFConverter.BarraProgresso();
            this.lbReset = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF Converter";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-1, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 25);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(199, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 10);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desenvolvido por João Vitor Pedon Bontempo";
            // 
            // flpFiles
            // 
            this.flpFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpFiles.AutoScroll = true;
            this.flpFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFiles.Location = new System.Drawing.Point(13, 98);
            this.flpFiles.Name = "flpFiles";
            this.flpFiles.Size = new System.Drawing.Size(353, 220);
            this.flpFiles.TabIndex = 4;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.ForeColor = System.Drawing.Color.White;
            this.btnConverter.Location = new System.Drawing.Point(12, 372);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(354, 27);
            this.btnConverter.TabIndex = 5;
            this.btnConverter.Text = "Converter arquivos";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Local de saída:";
            // 
            // btnNovoArquivo
            // 
            this.btnNovoArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNovoArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoArquivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoArquivo.ForeColor = System.Drawing.Color.White;
            this.btnNovoArquivo.Location = new System.Drawing.Point(340, 64);
            this.btnNovoArquivo.Name = "btnNovoArquivo";
            this.btnNovoArquivo.Size = new System.Drawing.Size(26, 27);
            this.btnNovoArquivo.TabIndex = 8;
            this.btnNovoArquivo.Text = "+";
            this.btnNovoArquivo.UseVisualStyleBackColor = false;
            this.btnNovoArquivo.Click += new System.EventHandler(this.btnNovoArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecione os arquivos que deseja converter:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputPath.Location = new System.Drawing.Point(16, 342);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(309, 22);
            this.txtOutputPath.TabIndex = 10;
            // 
            // btnSelecionarOutput
            // 
            this.btnSelecionarOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSelecionarOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarOutput.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarOutput.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarOutput.Location = new System.Drawing.Point(331, 339);
            this.btnSelecionarOutput.Name = "btnSelecionarOutput";
            this.btnSelecionarOutput.Size = new System.Drawing.Size(35, 27);
            this.btnSelecionarOutput.TabIndex = 11;
            this.btnSelecionarOutput.Text = "...";
            this.btnSelecionarOutput.UseVisualStyleBackColor = false;
            this.btnSelecionarOutput.Click += new System.EventHandler(this.btnSelecionarOutput_Click);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.Multiselect = true;
            this.ofdSelectFile.Title = "Selecione um ou mais arquivos para converter";
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.Location = new System.Drawing.Point(63, 405);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(280, 16);
            this.lbLoading.TabIndex = 13;
            this.lbLoading.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.lbLoading.Visible = false;
            // 
            // pbxLoading
            // 
            this.pbxLoading.Image = global::GoodTimePDFConverter.Properties.Resources.loading;
            this.pbxLoading.Location = new System.Drawing.Point(12, 405);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(45, 45);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLoading.TabIndex = 12;
            this.pbxLoading.TabStop = false;
            this.pbxLoading.Visible = false;
            // 
            // bwConversor
            // 
            this.bwConversor.WorkerReportsProgress = true;
            this.bwConversor.WorkerSupportsCancellation = true;
            this.bwConversor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConversor_DoWork);
            this.bwConversor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwConversor_ProgressChanged);
            this.bwConversor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwConversor_RunWorkerCompleted);
            // 
            // lbPorcentagem
            // 
            this.lbPorcentagem.AutoSize = true;
            this.lbPorcentagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentagem.Location = new System.Drawing.Point(338, 432);
            this.lbPorcentagem.Name = "lbPorcentagem";
            this.lbPorcentagem.Size = new System.Drawing.Size(25, 16);
            this.lbPorcentagem.TabIndex = 15;
            this.lbPorcentagem.Text = "0%";
            this.lbPorcentagem.Visible = false;
            // 
            // pbarProgresso
            // 
            this.pbarProgresso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbarProgresso.CorFundo = System.Drawing.Color.White;
            this.pbarProgresso.CorProgresso = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbarProgresso.Location = new System.Drawing.Point(66, 431);
            this.pbarProgresso.Maximo = 3;
            this.pbarProgresso.Name = "pbarProgresso";
            this.pbarProgresso.Size = new System.Drawing.Size(267, 19);
            this.pbarProgresso.TabIndex = 16;
            this.pbarProgresso.Valor = 1;
            this.pbarProgresso.Visible = false;
            // 
            // lbReset
            // 
            this.lbReset.AutoSize = true;
            this.lbReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbReset.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbReset.Location = new System.Drawing.Point(292, 317);
            this.lbReset.Name = "lbReset";
            this.lbReset.Size = new System.Drawing.Size(75, 13);
            this.lbReset.TabIndex = 17;
            this.lbReset.Text = "Limpar tudo";
            this.lbReset.Click += new System.EventHandler(this.lbReset_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 473);
            this.Controls.Add(this.pbarProgresso);
            this.Controls.Add(this.lbPorcentagem);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.pbxLoading);
            this.Controls.Add(this.btnSelecionarOutput);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovoArquivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.flpFiles);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNet PDF Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNovoArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnSelecionarOutput;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.FolderBrowserDialog fbdOutputPath;
        public System.Windows.Forms.FlowLayoutPanel flpFiles;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Label lbLoading;
        private System.ComponentModel.BackgroundWorker bwConversor;
        private BarraProgresso barraProgresso1;
        private System.Windows.Forms.Label lbPorcentagem;
        private BarraProgresso pbarProgresso;
        private System.Windows.Forms.Label lbReset;
    }
}