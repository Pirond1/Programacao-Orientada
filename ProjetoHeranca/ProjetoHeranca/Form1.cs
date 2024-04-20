using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoHeranca
{
    public partial class Form1 : Form
    {

        Funcionario obj;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Funcionario objFunc = new Funcionario() 
            { 
                cargo = "Analista",
                dataNascimento = DateTime.Now,
                matricula = 123,
                nome = "Gustavo",
                status = "Ativo",
                valorHora = 50
            };

            Gerente objGere = new Gerente()
            {
                cargo = "Gerente",
                dataNascimento = DateTime.Now,
                matricula = 321,
                nome = "Eduardo",
                status = "Ativo",
                valorHora = 100,
                valorComissao = 10,
                qtdFuncionarios = 11
            };



        }

        private void ckGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGerente.Checked)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /* Fazer Validações */
            if (ckGerente.Checked)
            {
                obj = new Gerente()
                {
                    cargo = txtCargo.Text,
                    dataNascimento = txtDataNascimento.Value,
                    matricula = int.Parse(txtMatricula.Text),
                    nome = txtNome.Text,
                    status = txtStatus.Text,
                    valorHora = Decimal.Parse(txtValorHora.Text),
                    valorComissao = Decimal.Parse(txtComissao.Text),
                    qtdFuncionarios = int.Parse(txtQtdFuncionario.Text),
                };
            }
            else
            {
                obj = new Funcionario()
                {
                    cargo = txtCargo.Text,
                    dataNascimento = txtDataNascimento.Value,
                    matricula = int.Parse(txtMatricula.Text),
                    nome = txtNome.Text,
                    status = txtStatus.Text,
                    valorHora = Decimal.Parse(txtValorHora.Text),
                };
            }


        }
    }
}
