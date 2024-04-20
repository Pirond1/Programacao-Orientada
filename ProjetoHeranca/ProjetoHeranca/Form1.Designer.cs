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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ckGerente = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQtdFuncionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(12, 30);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(197, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(12, 121);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(197, 20);
            this.txtCargo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cargo";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(12, 171);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(197, 20);
            this.txtValorHora.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Hora";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 219);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(197, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(12, 269);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(197, 20);
            this.txtDataNascimento.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Nascimento";
            // 
            // ckGerente
            // 
            this.ckGerente.AutoSize = true;
            this.ckGerente.Location = new System.Drawing.Point(12, 309);
            this.ckGerente.Name = "ckGerente";
            this.ckGerente.Size = new System.Drawing.Size(80, 17);
            this.ckGerente.TabIndex = 12;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 137);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerente";
            this.groupBox1.Visible = false;
            // 
            // txtQtdFuncionario
            // 
            this.txtQtdFuncionario.Location = new System.Drawing.Point(6, 95);
            this.txtQtdFuncionario.Name = "txtQtdFuncionario";
            this.txtQtdFuncionario.Size = new System.Drawing.Size(191, 20);
            this.txtQtdFuncionario.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantidade Funcionários";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(6, 48);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(191, 20);
            this.txtComissao.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Valor Comissão";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(67, 477);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 39);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 525);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckGerente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckGerente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQtdFuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnSalvar;
    }
}

