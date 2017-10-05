namespace INTERFACE.Cadastro
{
    partial class frmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbJapones = new System.Windows.Forms.CheckBox();
            this.cbIngles = new System.Windows.Forms.CheckBox();
            this.cbPortugues = new System.Windows.Forms.CheckBox();
            this.cbMatematica = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescontoMensal = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.lbValorMatricula = new System.Windows.Forms.Label();
            this.lbValorMensalidade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbMensalidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.mbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbResponsavel = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.lbNomeResponsavel = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.pnResponsavel = new System.Windows.Forms.Panel();
            this.rbResponsavelNao = new System.Windows.Forms.RadioButton();
            this.rbResponsavelSim = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnResponsavel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbJapones);
            this.groupBox1.Controls.Add(this.cbIngles);
            this.groupBox1.Controls.Add(this.cbPortugues);
            this.groupBox1.Controls.Add(this.cbMatematica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matérias";
            // 
            // cbJapones
            // 
            this.cbJapones.AutoSize = true;
            this.cbJapones.Location = new System.Drawing.Point(36, 179);
            this.cbJapones.Name = "cbJapones";
            this.cbJapones.Size = new System.Drawing.Size(107, 29);
            this.cbJapones.TabIndex = 3;
            this.cbJapones.Text = "Japonês";
            this.cbJapones.UseVisualStyleBackColor = true;
            this.cbJapones.CheckedChanged += new System.EventHandler(this.cbJapones_CheckedChanged);
            // 
            // cbIngles
            // 
            this.cbIngles.AutoSize = true;
            this.cbIngles.Location = new System.Drawing.Point(36, 134);
            this.cbIngles.Name = "cbIngles";
            this.cbIngles.Size = new System.Drawing.Size(83, 29);
            this.cbIngles.TabIndex = 2;
            this.cbIngles.Text = "Inglês";
            this.cbIngles.UseVisualStyleBackColor = true;
            this.cbIngles.CheckedChanged += new System.EventHandler(this.cbIngles_CheckedChanged);
            // 
            // cbPortugues
            // 
            this.cbPortugues.AutoSize = true;
            this.cbPortugues.Location = new System.Drawing.Point(36, 89);
            this.cbPortugues.Name = "cbPortugues";
            this.cbPortugues.Size = new System.Drawing.Size(120, 29);
            this.cbPortugues.TabIndex = 1;
            this.cbPortugues.Text = "Portugues";
            this.cbPortugues.UseVisualStyleBackColor = true;
            this.cbPortugues.CheckedChanged += new System.EventHandler(this.cbPortugues_CheckedChanged);
            // 
            // cbMatematica
            // 
            this.cbMatematica.AutoSize = true;
            this.cbMatematica.Location = new System.Drawing.Point(36, 44);
            this.cbMatematica.Name = "cbMatematica";
            this.cbMatematica.Size = new System.Drawing.Size(132, 29);
            this.cbMatematica.TabIndex = 0;
            this.cbMatematica.Text = "Matematica";
            this.cbMatematica.UseVisualStyleBackColor = true;
            this.cbMatematica.CheckedChanged += new System.EventHandler(this.cbMatematica_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescontoMensal);
            this.groupBox2.Controls.Add(this.txtDesconto);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbValorTotal);
            this.groupBox2.Controls.Add(this.lbValorMatricula);
            this.groupBox2.Controls.Add(this.lbValorMensalidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbDesconto);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Controls.Add(this.lbMensalidade);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(232, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 239);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento";
            // 
            // txtDescontoMensal
            // 
            this.txtDescontoMensal.Location = new System.Drawing.Point(332, 61);
            this.txtDescontoMensal.Name = "txtDescontoMensal";
            this.txtDescontoMensal.Size = new System.Drawing.Size(66, 30);
            this.txtDescontoMensal.TabIndex = 17;
            this.txtDescontoMensal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontoMensal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoMensal_KeyPress);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(332, 23);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(66, 30);
            this.txtDesconto.TabIndex = 16;
            this.txtDesconto.Tag = "";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(293, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 80);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Des. Mensal: ";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Location = new System.Drawing.Point(219, 199);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(50, 25);
            this.lbValorTotal.TabIndex = 14;
            this.lbValorTotal.Text = "0.00";
            // 
            // lbValorMatricula
            // 
            this.lbValorMatricula.AutoSize = true;
            this.lbValorMatricula.Location = new System.Drawing.Point(219, 117);
            this.lbValorMatricula.Name = "lbValorMatricula";
            this.lbValorMatricula.Size = new System.Drawing.Size(50, 25);
            this.lbValorMatricula.TabIndex = 8;
            this.lbValorMatricula.Text = "0.00";
            this.lbValorMatricula.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbValorMensalidade
            // 
            this.lbValorMensalidade.AutoSize = true;
            this.lbValorMensalidade.Location = new System.Drawing.Point(219, 158);
            this.lbValorMensalidade.Name = "lbValorMensalidade";
            this.lbValorMensalidade.Size = new System.Drawing.Size(50, 25);
            this.lbValorMensalidade.TabIndex = 11;
            this.lbValorMensalidade.Text = "0.00";
            this.lbValorMensalidade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "R$";
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(18, 28);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(106, 25);
            this.lbDesconto.TabIndex = 0;
            this.lbDesconto.Text = "Desconto: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(14, 199);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(67, 25);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Total: ";
            // 
            // lbMensalidade
            // 
            this.lbMensalidade.AutoSize = true;
            this.lbMensalidade.Location = new System.Drawing.Point(14, 158);
            this.lbMensalidade.Name = "lbMensalidade";
            this.lbMensalidade.Size = new System.Drawing.Size(135, 25);
            this.lbMensalidade.TabIndex = 9;
            this.lbMensalidade.Text = "Mensalidade: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Matricula: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIdAluno);
            this.groupBox3.Controls.Add(this.mbCPF);
            this.groupBox3.Controls.Add(this.mbTelefone);
            this.groupBox3.Controls.Add(this.lbTelefone);
            this.groupBox3.Controls.Add(this.lbResponsavel);
            this.groupBox3.Controls.Add(this.lbCPF);
            this.groupBox3.Controls.Add(this.txtNomeResponsavel);
            this.groupBox3.Controls.Add(this.lbNomeResponsavel);
            this.groupBox3.Controls.Add(this.lbID);
            this.groupBox3.Controls.Add(this.lbNomeAluno);
            this.groupBox3.Controls.Add(this.txtNomeAluno);
            this.groupBox3.Controls.Add(this.pnResponsavel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 252);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações Pessoais";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAluno.Location = new System.Drawing.Point(52, 114);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(100, 26);
            this.txtIdAluno.TabIndex = 3;
            this.txtIdAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdAluno_KeyPress);
            // 
            // mbCPF
            // 
            this.mbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbCPF.Location = new System.Drawing.Point(210, 114);
            this.mbCPF.Mask = "000,000,000-00";
            this.mbCPF.Name = "mbCPF";
            this.mbCPF.Size = new System.Drawing.Size(126, 26);
            this.mbCPF.TabIndex = 5;
            this.mbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mbCPF_KeyPress);
            // 
            // mbTelefone
            // 
            this.mbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbTelefone.Location = new System.Drawing.Point(403, 114);
            this.mbTelefone.Mask = "(00)0000-0000";
            this.mbTelefone.Name = "mbTelefone";
            this.mbTelefone.Size = new System.Drawing.Size(119, 26);
            this.mbTelefone.TabIndex = 7;
            this.mbTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mbTelefone_KeyPress);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTelefone.Location = new System.Drawing.Point(403, 91);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(71, 20);
            this.lbTelefone.TabIndex = 6;
            this.lbTelefone.Text = "Telefone";
            this.lbTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.AutoSize = true;
            this.lbResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResponsavel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbResponsavel.Location = new System.Drawing.Point(413, 148);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(165, 20);
            this.lbResponsavel.TabIndex = 8;
            this.lbResponsavel.Text = "Possui Responsável ?";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCPF.Location = new System.Drawing.Point(210, 91);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(40, 20);
            this.lbCPF.TabIndex = 4;
            this.lbCPF.Text = "CPF";
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeResponsavel.Location = new System.Drawing.Point(52, 202);
            this.txtNomeResponsavel.MaxLength = 50;
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(526, 26);
            this.txtNomeResponsavel.TabIndex = 11;
            this.txtNomeResponsavel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeResponsavel_KeyPress);
            // 
            // lbNomeResponsavel
            // 
            this.lbNomeResponsavel.AutoSize = true;
            this.lbNomeResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeResponsavel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomeResponsavel.Location = new System.Drawing.Point(52, 180);
            this.lbNomeResponsavel.Name = "lbNomeResponsavel";
            this.lbNomeResponsavel.Size = new System.Drawing.Size(162, 20);
            this.lbNomeResponsavel.TabIndex = 10;
            this.lbNomeResponsavel.Text = "Nome do responsável";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbID.Location = new System.Drawing.Point(52, 91);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(69, 20);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID aluno";
            // 
            // lbNomeAluno
            // 
            this.lbNomeAluno.AutoSize = true;
            this.lbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomeAluno.Location = new System.Drawing.Point(52, 35);
            this.lbNomeAluno.Name = "lbNomeAluno";
            this.lbNomeAluno.Size = new System.Drawing.Size(116, 20);
            this.lbNomeAluno.TabIndex = 0;
            this.lbNomeAluno.Text = "Nome do aluno";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.AccessibleDescription = "J";
            this.txtNomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(52, 59);
            this.txtNomeAluno.MaxLength = 50;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(526, 26);
            this.txtNomeAluno.TabIndex = 1;
            this.txtNomeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAluno_KeyPress);
            // 
            // pnResponsavel
            // 
            this.pnResponsavel.Controls.Add(this.rbResponsavelNao);
            this.pnResponsavel.Controls.Add(this.rbResponsavelSim);
            this.pnResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnResponsavel.Location = new System.Drawing.Point(416, 161);
            this.pnResponsavel.Name = "pnResponsavel";
            this.pnResponsavel.Size = new System.Drawing.Size(159, 35);
            this.pnResponsavel.TabIndex = 9;
            // 
            // rbResponsavelNao
            // 
            this.rbResponsavelNao.AutoSize = true;
            this.rbResponsavelNao.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.rbResponsavelNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResponsavelNao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbResponsavelNao.Location = new System.Drawing.Point(87, 7);
            this.rbResponsavelNao.Name = "rbResponsavelNao";
            this.rbResponsavelNao.Size = new System.Drawing.Size(54, 22);
            this.rbResponsavelNao.TabIndex = 1;
            this.rbResponsavelNao.Text = "Não";
            this.rbResponsavelNao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbResponsavelNao.UseVisualStyleBackColor = true;
            this.rbResponsavelNao.CheckedChanged += new System.EventHandler(this.rbResponsavelNao_CheckedChanged);
            // 
            // rbResponsavelSim
            // 
            this.rbResponsavelSim.AutoSize = true;
            this.rbResponsavelSim.Checked = true;
            this.rbResponsavelSim.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.rbResponsavelSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResponsavelSim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbResponsavelSim.Location = new System.Drawing.Point(11, 7);
            this.rbResponsavelSim.Name = "rbResponsavelSim";
            this.rbResponsavelSim.Size = new System.Drawing.Size(52, 22);
            this.rbResponsavelSim.TabIndex = 0;
            this.rbResponsavelSim.TabStop = true;
            this.rbResponsavelSim.Text = "Sim";
            this.rbResponsavelSim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbResponsavelSim.UseVisualStyleBackColor = true;
            this.rbResponsavelSim.CheckedChanged += new System.EventHandler(this.rbResponsavelSim_CheckedChanged);
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(671, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-BOL\\Cadastrar Aluno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnResponsavel.ResumeLayout(false);
            this.pnResponsavel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbJapones;
        private System.Windows.Forms.CheckBox cbIngles;
        private System.Windows.Forms.CheckBox cbPortugues;
        private System.Windows.Forms.CheckBox cbMatematica;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMensalidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIdAluno;
        private System.Windows.Forms.MaskedTextBox mbCPF;
        private System.Windows.Forms.MaskedTextBox mbTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbResponsavel;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txtNomeResponsavel;
        private System.Windows.Forms.Label lbNomeResponsavel;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Panel pnResponsavel;
        private System.Windows.Forms.RadioButton rbResponsavelNao;
        private System.Windows.Forms.RadioButton rbResponsavelSim;
        public System.Windows.Forms.Label lbValorTotal;
        public System.Windows.Forms.Label lbValorMatricula;
        public System.Windows.Forms.Label lbValorMensalidade;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtDescontoMensal;

    }
}