namespace ProjetoClasses
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
            this.ggpConta = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.ggpConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // ggpConta
            // 
            this.ggpConta.Controls.Add(this.btnSaldo);
            this.ggpConta.Controls.Add(this.btnDepositar);
            this.ggpConta.Controls.Add(this.btnSacar);
            this.ggpConta.Controls.Add(this.btnLimpar);
            this.ggpConta.Controls.Add(this.btnRecuperar);
            this.ggpConta.Controls.Add(this.label7);
            this.ggpConta.Controls.Add(this.label6);
            this.ggpConta.Controls.Add(this.txtValor);
            this.ggpConta.Controls.Add(this.label5);
            this.ggpConta.Controls.Add(this.txtSaldo);
            this.ggpConta.Controls.Add(this.label4);
            this.ggpConta.Controls.Add(this.txtCPF);
            this.ggpConta.Controls.Add(this.label3);
            this.ggpConta.Controls.Add(this.txtNome);
            this.ggpConta.Controls.Add(this.label2);
            this.ggpConta.Controls.Add(this.BtnSalvar);
            this.ggpConta.Controls.Add(this.label1);
            this.ggpConta.Controls.Add(this.txtCodigo);
            this.ggpConta.ForeColor = System.Drawing.SystemColors.Control;
            this.ggpConta.Location = new System.Drawing.Point(12, 12);
            this.ggpConta.Name = "ggpConta";
            this.ggpConta.Size = new System.Drawing.Size(548, 354);
            this.ggpConta.TabIndex = 1;
            this.ggpConta.TabStop = false;
            this.ggpConta.Text = "Conta Corrente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(80, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(83, 199);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(121, 20);
            this.txtSaldo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(160, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(162, 91);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(122, 20);
            this.txtCPF.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvar.Location = new System.Drawing.Point(18, 235);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(87, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTA";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(18, 91);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRecuperar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecuperar.Location = new System.Drawing.Point(115, 235);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 13;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(209, 235);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(381, 129);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(378, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(332, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "SAQUE E DEPÓSITO";
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSacar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSacar.Location = new System.Drawing.Point(337, 173);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 15;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.SystemColors.Control;
            this.btnDepositar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDepositar.Location = new System.Drawing.Point(440, 173);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 16;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaldo.Location = new System.Drawing.Point(389, 210);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnSaldo.TabIndex = 17;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 373);
            this.Controls.Add(this.ggpConta);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ggpConta.ResumeLayout(false);
            this.ggpConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ggpConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
    }
}

