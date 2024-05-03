namespace Santander
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.text10 = new System.Windows.Forms.Label();
            this.txtTaxaRendimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.text5 = new System.Windows.Forms.Label();
            this.btnCalcSaldo = new System.Windows.Forms.Button();
            this.ckPoupanca = new System.Windows.Forms.CheckBox();
            this.ggpPopupanca = new System.Windows.Forms.GroupBox();
            this.txtDiaRendimento = new System.Windows.Forms.TextBox();
            this.ggpTerminal = new System.Windows.Forms.GroupBox();
            this.ckEspecial = new System.Windows.Forms.CheckBox();
            this.ggpEspecial = new System.Windows.Forms.GroupBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ggpPopupanca.SuspendLayout();
            this.ggpTerminal.SuspendLayout();
            this.ggpEspecial.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(60, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(155, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(137, 280);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(61, 23);
            this.btnSacar.TabIndex = 2;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(60, 183);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(155, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(57, 87);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(90, 13);
            this.text2.TabIndex = 6;
            this.text2.Text = "Número da Conta";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(60, 103);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(126, 20);
            this.txtConta.TabIndex = 5;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(204, 280);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(61, 23);
            this.btnDepositar.TabIndex = 7;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // text10
            // 
            this.text10.AutoSize = true;
            this.text10.Location = new System.Drawing.Point(110, 16);
            this.text10.Name = "text10";
            this.text10.Size = new System.Drawing.Size(106, 13);
            this.text10.TabIndex = 11;
            this.text10.Text = "Taxa de Rendimento";
            // 
            // txtTaxaRendimento
            // 
            this.txtTaxaRendimento.Location = new System.Drawing.Point(113, 32);
            this.txtTaxaRendimento.Name = "txtTaxaRendimento";
            this.txtTaxaRendimento.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaRendimento.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dia do Rendimento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(7, 280);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(61, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(74, 280);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(60, 232);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(155, 20);
            this.txtValor.TabIndex = 16;
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.Location = new System.Drawing.Point(57, 216);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(77, 13);
            this.text5.TabIndex = 17;
            this.text5.Text = "Informe o valor";
            // 
            // btnCalcSaldo
            // 
            this.btnCalcSaldo.Location = new System.Drawing.Point(9, 65);
            this.btnCalcSaldo.Name = "btnCalcSaldo";
            this.btnCalcSaldo.Size = new System.Drawing.Size(74, 52);
            this.btnCalcSaldo.TabIndex = 18;
            this.btnCalcSaldo.Text = "Saldo Poupança";
            this.btnCalcSaldo.UseVisualStyleBackColor = true;
            this.btnCalcSaldo.Click += new System.EventHandler(this.btnCalcSaldo_Click);
            // 
            // ckPoupanca
            // 
            this.ckPoupanca.AutoSize = true;
            this.ckPoupanca.Location = new System.Drawing.Point(60, 129);
            this.ckPoupanca.Name = "ckPoupanca";
            this.ckPoupanca.Size = new System.Drawing.Size(90, 17);
            this.ckPoupanca.TabIndex = 19;
            this.ckPoupanca.Text = "É poupança?";
            this.ckPoupanca.UseVisualStyleBackColor = true;
            this.ckPoupanca.CheckedChanged += new System.EventHandler(this.ckPoupanca_CheckedChanged);
            // 
            // ggpPopupanca
            // 
            this.ggpPopupanca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ggpPopupanca.Controls.Add(this.txtDiaRendimento);
            this.ggpPopupanca.Controls.Add(this.label3);
            this.ggpPopupanca.Controls.Add(this.btnCalcSaldo);
            this.ggpPopupanca.Controls.Add(this.text10);
            this.ggpPopupanca.Controls.Add(this.txtTaxaRendimento);
            this.ggpPopupanca.Location = new System.Drawing.Point(311, 12);
            this.ggpPopupanca.Name = "ggpPopupanca";
            this.ggpPopupanca.Size = new System.Drawing.Size(230, 131);
            this.ggpPopupanca.TabIndex = 17;
            this.ggpPopupanca.TabStop = false;
            this.ggpPopupanca.Text = "Poupança";
            this.ggpPopupanca.Visible = false;
            // 
            // txtDiaRendimento
            // 
            this.txtDiaRendimento.Location = new System.Drawing.Point(7, 32);
            this.txtDiaRendimento.Name = "txtDiaRendimento";
            this.txtDiaRendimento.Size = new System.Drawing.Size(100, 20);
            this.txtDiaRendimento.TabIndex = 19;
            // 
            // ggpTerminal
            // 
            this.ggpTerminal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ggpTerminal.Controls.Add(this.ckEspecial);
            this.ggpTerminal.Controls.Add(this.ckPoupanca);
            this.ggpTerminal.Controls.Add(this.txtValor);
            this.ggpTerminal.Controls.Add(this.text5);
            this.ggpTerminal.Controls.Add(this.txtNome);
            this.ggpTerminal.Controls.Add(this.btnLimpar);
            this.ggpTerminal.Controls.Add(this.label1);
            this.ggpTerminal.Controls.Add(this.btnSalvar);
            this.ggpTerminal.Controls.Add(this.btnSacar);
            this.ggpTerminal.Controls.Add(this.txtSaldo);
            this.ggpTerminal.Controls.Add(this.label2);
            this.ggpTerminal.Controls.Add(this.txtConta);
            this.ggpTerminal.Controls.Add(this.text2);
            this.ggpTerminal.Controls.Add(this.btnDepositar);
            this.ggpTerminal.Location = new System.Drawing.Point(12, 12);
            this.ggpTerminal.Name = "ggpTerminal";
            this.ggpTerminal.Size = new System.Drawing.Size(284, 331);
            this.ggpTerminal.TabIndex = 16;
            this.ggpTerminal.TabStop = false;
            this.ggpTerminal.Text = "Terminal";
            // 
            // ckEspecial
            // 
            this.ckEspecial.AutoSize = true;
            this.ckEspecial.Location = new System.Drawing.Point(156, 129);
            this.ckEspecial.Name = "ckEspecial";
            this.ckEspecial.Size = new System.Drawing.Size(81, 17);
            this.ckEspecial.TabIndex = 20;
            this.ckEspecial.Text = "É especial?";
            this.ckEspecial.UseVisualStyleBackColor = true;
            this.ckEspecial.CheckedChanged += new System.EventHandler(this.ckEspecial_CheckedChanged);
            // 
            // ggpEspecial
            // 
            this.ggpEspecial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ggpEspecial.Controls.Add(this.txtLimite);
            this.ggpEspecial.Controls.Add(this.label4);
            this.ggpEspecial.Location = new System.Drawing.Point(311, 164);
            this.ggpEspecial.Name = "ggpEspecial";
            this.ggpEspecial.Size = new System.Drawing.Size(230, 114);
            this.ggpEspecial.TabIndex = 18;
            this.ggpEspecial.TabStop = false;
            this.ggpEspecial.Text = "Especial";
            this.ggpEspecial.Visible = false;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(7, 32);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(102, 20);
            this.txtLimite.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Limite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 363);
            this.Controls.Add(this.ggpEspecial);
            this.Controls.Add(this.ggpPopupanca);
            this.Controls.Add(this.ggpTerminal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ggpPopupanca.ResumeLayout(false);
            this.ggpPopupanca.PerformLayout();
            this.ggpTerminal.ResumeLayout(false);
            this.ggpTerminal.PerformLayout();
            this.ggpEspecial.ResumeLayout(false);
            this.ggpEspecial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label text10;
        private System.Windows.Forms.TextBox txtTaxaRendimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Button btnCalcSaldo;
        private System.Windows.Forms.CheckBox ckPoupanca;
        private System.Windows.Forms.GroupBox ggpPopupanca;
        private System.Windows.Forms.GroupBox ggpTerminal;
        private System.Windows.Forms.TextBox txtDiaRendimento;
        private System.Windows.Forms.GroupBox ggpEspecial;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckEspecial;
    }
}

