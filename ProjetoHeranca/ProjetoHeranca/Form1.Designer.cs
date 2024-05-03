namespace ProjetoHeranca
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckGerente = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQtdFuncionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPorcentagemHora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnValorComissaoNovo = new System.Windows.Forms.Button();
            this.txtPorcentagemComissao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalcularSalarioComissao = new System.Windows.Forms.Button();
            this.txtTotalHorasComissao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckGerente
            // 
            this.ckGerente.AutoSize = true;
            this.ckGerente.Location = new System.Drawing.Point(29, 332);
            this.ckGerente.Name = "ckGerente";
            this.ckGerente.Size = new System.Drawing.Size(80, 17);
            this.ckGerente.TabIndex = 7;
            this.ckGerente.Text = "É Gerente?";
            this.ckGerente.UseVisualStyleBackColor = true;
            this.ckGerente.CheckedChanged += new System.EventHandler(this.ckGerente_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQtdFuncionario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtComissao);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(12, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerente";
            this.groupBox1.Visible = false;
            // 
            // txtQtdFuncionario
            // 
            this.txtQtdFuncionario.Location = new System.Drawing.Point(17, 95);
            this.txtQtdFuncionario.Name = "txtQtdFuncionario";
            this.txtQtdFuncionario.Size = new System.Drawing.Size(197, 20);
            this.txtQtdFuncionario.TabIndex = 10;
            this.txtQtdFuncionario.Tag = "Quantidade Funcionários";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantidade Funcionários";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(17, 47);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(197, 20);
            this.txtComissao.TabIndex = 9;
            this.txtComissao.Tag = "Valor Comissão";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Valor Comissão";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(29, 498);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 39);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.label6);
            this.gbDados.Controls.Add(this.txtDataNascimento);
            this.gbDados.Controls.Add(this.txtStatus);
            this.gbDados.Controls.Add(this.label5);
            this.gbDados.Controls.Add(this.txtValorHora);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Controls.Add(this.txtCargo);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.txtMatricula);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(237, 314);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Data Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(17, 279);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(197, 20);
            this.txtDataNascimento.TabIndex = 6;
            this.txtDataNascimento.Tag = "Data Nascimento";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(17, 229);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(197, 20);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.Tag = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(17, 181);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(197, 20);
            this.txtValorHora.TabIndex = 4;
            this.txtValorHora.Tag = "Valor Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor Hora";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(17, 131);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(197, 20);
            this.txtCargo.TabIndex = 3;
            this.txtCargo.Tag = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cargo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Tag = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(17, 40);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(197, 20);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.Tag = "Matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Matricula";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(135, 498);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(91, 39);
            this.btnRecuperar.TabIndex = 12;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // txtTotalHoras
            // 
            this.txtTotalHoras.Location = new System.Drawing.Point(274, 52);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.Size = new System.Drawing.Size(197, 20);
            this.txtTotalHoras.TabIndex = 13;
            this.txtTotalHoras.Tag = "Total Horas Salário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total de Horas";
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(274, 80);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(91, 39);
            this.btnCalcularSalario.TabIndex = 14;
            this.btnCalcularSalario.Text = "Calcular Salário";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Atualizar Valor Hora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPorcentagemHora
            // 
            this.txtPorcentagemHora.Location = new System.Drawing.Point(274, 158);
            this.txtPorcentagemHora.Name = "txtPorcentagemHora";
            this.txtPorcentagemHora.Size = new System.Drawing.Size(197, 20);
            this.txtPorcentagemHora.TabIndex = 15;
            this.txtPorcentagemHora.Tag = "Nova Porcentagem Valor Hora";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nova Porcentagem Valor Hora";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnValorComissaoNovo);
            this.groupBox2.Controls.Add(this.txtPorcentagemComissao);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnCalcularSalarioComissao);
            this.groupBox2.Controls.Add(this.txtTotalHorasComissao);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(257, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 251);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // btnValorComissaoNovo
            // 
            this.btnValorComissaoNovo.Location = new System.Drawing.Point(17, 171);
            this.btnValorComissaoNovo.Name = "btnValorComissaoNovo";
            this.btnValorComissaoNovo.Size = new System.Drawing.Size(91, 39);
            this.btnValorComissaoNovo.TabIndex = 21;
            this.btnValorComissaoNovo.Text = "Atualizar Valor";
            this.btnValorComissaoNovo.UseVisualStyleBackColor = true;
            this.btnValorComissaoNovo.Click += new System.EventHandler(this.btnValorComissaoNovo_Click);
            // 
            // txtPorcentagemComissao
            // 
            this.txtPorcentagemComissao.Location = new System.Drawing.Point(17, 145);
            this.txtPorcentagemComissao.Name = "txtPorcentagemComissao";
            this.txtPorcentagemComissao.Size = new System.Drawing.Size(197, 20);
            this.txtPorcentagemComissao.TabIndex = 20;
            this.txtPorcentagemComissao.Tag = "Nova Porcentagem Valor Comissão";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nova Porcentagem Valor Comissão";
            // 
            // btnCalcularSalarioComissao
            // 
            this.btnCalcularSalarioComissao.Location = new System.Drawing.Point(17, 73);
            this.btnCalcularSalarioComissao.Name = "btnCalcularSalarioComissao";
            this.btnCalcularSalarioComissao.Size = new System.Drawing.Size(91, 39);
            this.btnCalcularSalarioComissao.TabIndex = 19;
            this.btnCalcularSalarioComissao.Text = "Calcular Salário com Comissão";
            this.btnCalcularSalarioComissao.UseVisualStyleBackColor = true;
            this.btnCalcularSalarioComissao.Click += new System.EventHandler(this.btnCalcularSalarioComissao_Click);
            // 
            // txtTotalHorasComissao
            // 
            this.txtTotalHorasComissao.Location = new System.Drawing.Point(17, 47);
            this.txtTotalHorasComissao.Name = "txtTotalHorasComissao";
            this.txtTotalHorasComissao.Size = new System.Drawing.Size(197, 20);
            this.txtTotalHorasComissao.TabIndex = 18;
            this.txtTotalHorasComissao.Tag = "Total de Horas Comissão";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Total de Horas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPorcentagemHora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.txtTotalHoras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckGerente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckGerente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQtdFuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPorcentagemHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnValorComissaoNovo;
        private System.Windows.Forms.TextBox txtTotalHorasComissao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPorcentagemComissao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalcularSalarioComissao;
    }
}

