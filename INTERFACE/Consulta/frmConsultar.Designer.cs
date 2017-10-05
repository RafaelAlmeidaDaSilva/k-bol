namespace INTERFACE.Consulta
{
    partial class frmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultar));
            this.pConsulta = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEfetuarPagamento = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnInformacaoAluno = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pConsulta
            // 
            this.pConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pConsulta.BackColor = System.Drawing.Color.SteelBlue;
            this.pConsulta.Controls.Add(this.label1);
            this.pConsulta.Controls.Add(this.pictureBox1);
            this.pConsulta.Controls.Add(this.btnEfetuarPagamento);
            this.pConsulta.Controls.Add(this.btnPesquisar);
            this.pConsulta.Controls.Add(this.btnInformacaoAluno);
            this.pConsulta.Controls.Add(this.txtPesquisar);
            this.pConsulta.Controls.Add(this.btnCadastrarAluno);
            this.pConsulta.Controls.Add(this.dataGridView1);
            this.pConsulta.Location = new System.Drawing.Point(14, 13);
            this.pConsulta.Name = "pConsulta";
            this.pConsulta.Size = new System.Drawing.Size(888, 505);
            this.pConsulta.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INTERFACE.Properties.Resources.KBOL_SPLASH;
            this.pictureBox1.Location = new System.Drawing.Point(737, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnEfetuarPagamento
            // 
            this.btnEfetuarPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuarPagamento.Location = new System.Drawing.Point(751, 438);
            this.btnEfetuarPagamento.Name = "btnEfetuarPagamento";
            this.btnEfetuarPagamento.Size = new System.Drawing.Size(111, 55);
            this.btnEfetuarPagamento.TabIndex = 37;
            this.btnEfetuarPagamento.Text = "Efetuar Pagamento";
            this.btnEfetuarPagamento.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(580, 40);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 45);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnInformacaoAluno
            // 
            this.btnInformacaoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacaoAluno.Location = new System.Drawing.Point(762, 302);
            this.btnInformacaoAluno.Name = "btnInformacaoAluno";
            this.btnInformacaoAluno.Size = new System.Drawing.Size(89, 57);
            this.btnInformacaoAluno.TabIndex = 35;
            this.btnInformacaoAluno.Text = "Informaçoes do Aluno";
            this.btnInformacaoAluno.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(162, 49);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(412, 26);
            this.txtPesquisar.TabIndex = 34;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.Location = new System.Drawing.Point(751, 155);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(117, 84);
            this.btnCadastrarAluno.TabIndex = 33;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 338);
            this.dataGridView1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 33;
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(919, 535);
            this.Controls.Add(this.pConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-BOL\\Consultar Aluno";
            this.pConsulta.ResumeLayout(false);
            this.pConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEfetuarPagamento;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnInformacaoAluno;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;




    }
}