namespace PojetoPolimorfismo
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
            this.ggbPrincipal = new System.Windows.Forms.GroupBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbtnGerente = new System.Windows.Forms.RadioButton();
            this.rdbtnHorista = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ddtData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ggbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ggbPrincipal
            // 
            this.ggbPrincipal.Controls.Add(this.btnRecuperar);
            this.ggbPrincipal.Controls.Add(this.btnSalvar);
            this.ggbPrincipal.Controls.Add(this.txtValorHora);
            this.ggbPrincipal.Controls.Add(this.label8);
            this.ggbPrincipal.Controls.Add(this.txtHorasTrabalhadas);
            this.ggbPrincipal.Controls.Add(this.label7);
            this.ggbPrincipal.Controls.Add(this.rdbtnGerente);
            this.ggbPrincipal.Controls.Add(this.rdbtnHorista);
            this.ggbPrincipal.Controls.Add(this.label6);
            this.ggbPrincipal.Controls.Add(this.ddtData);
            this.ggbPrincipal.Controls.Add(this.label5);
            this.ggbPrincipal.Controls.Add(this.txtCPF);
            this.ggbPrincipal.Controls.Add(this.label4);
            this.ggbPrincipal.Controls.Add(this.txtRG);
            this.ggbPrincipal.Controls.Add(this.label3);
            this.ggbPrincipal.Controls.Add(this.txtMatricula);
            this.ggbPrincipal.Controls.Add(this.label2);
            this.ggbPrincipal.Controls.Add(this.txtNome);
            this.ggbPrincipal.Controls.Add(this.label1);
            this.ggbPrincipal.Location = new System.Drawing.Point(13, 13);
            this.ggbPrincipal.Name = "ggbPrincipal";
            this.ggbPrincipal.Size = new System.Drawing.Size(410, 358);
            this.ggbPrincipal.TabIndex = 0;
            this.ggbPrincipal.TabStop = false;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(238, 305);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(112, 39);
            this.btnRecuperar.TabIndex = 18;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(45, 305);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 39);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(238, 247);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(147, 20);
            this.txtValorHora.TabIndex = 16;
            this.txtValorHora.Tag = "Valor Hora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor Hora";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(10, 247);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(147, 20);
            this.txtHorasTrabalhadas.TabIndex = 14;
            this.txtHorasTrabalhadas.Tag = "Qtd Horas Trabalhadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Qtd Horas Trabalhadas";
            // 
            // rdbtnGerente
            // 
            this.rdbtnGerente.AutoSize = true;
            this.rdbtnGerente.Location = new System.Drawing.Point(238, 183);
            this.rdbtnGerente.Name = "rdbtnGerente";
            this.rdbtnGerente.Size = new System.Drawing.Size(63, 17);
            this.rdbtnGerente.TabIndex = 12;
            this.rdbtnGerente.TabStop = true;
            this.rdbtnGerente.Tag = "Botão de Cargo";
            this.rdbtnGerente.Text = "Gerente";
            this.rdbtnGerente.UseVisualStyleBackColor = true;
            // 
            // rdbtnHorista
            // 
            this.rdbtnHorista.AutoSize = true;
            this.rdbtnHorista.Location = new System.Drawing.Point(238, 160);
            this.rdbtnHorista.Name = "rdbtnHorista";
            this.rdbtnHorista.Size = new System.Drawing.Size(58, 17);
            this.rdbtnHorista.TabIndex = 11;
            this.rdbtnHorista.TabStop = true;
            this.rdbtnHorista.Tag = "Botão de Cargo";
            this.rdbtnHorista.Text = "Horista";
            this.rdbtnHorista.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cargo";
            // 
            // ddtData
            // 
            this.ddtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddtData.Location = new System.Drawing.Point(10, 160);
            this.ddtData.Name = "ddtData";
            this.ddtData.Size = new System.Drawing.Size(147, 20);
            this.ddtData.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de Nascimento";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(238, 93);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(147, 20);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.Tag = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(10, 93);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(147, 20);
            this.txtRG.TabIndex = 5;
            this.txtRG.Tag = "Rg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(238, 36);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(147, 20);
            this.txtMatricula.TabIndex = 3;
            this.txtMatricula.Tag = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrícula";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(154, 454);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 39);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(136, 409);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(147, 20);
            this.txtSalario.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(150, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Calcular Salário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 513);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.ggbPrincipal);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ggbPrincipal.ResumeLayout(false);
            this.ggbPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ggbPrincipal;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbtnGerente;
        private System.Windows.Forms.RadioButton rdbtnHorista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ddtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label9;
    }
}

