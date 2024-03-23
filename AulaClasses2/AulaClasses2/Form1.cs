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

namespace AulaClasses2
{
    public partial class Form1 : Form
    {

        Funcionario obj; //Declaração

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var valida = true;

            foreach (var item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    if(((TextBox)item).Text == "")
                        valida = false;
                }
            }
            if(valida == true)
            {
                obj = new Funcionario() 
                { 
                    Matricula = int.Parse(txtMatricula.Text),
                    Nome = txtNome.Text,
                    Cargo = txtCargo.Text,
                    Salario = Decimal.Parse(txtSalario.Text),
                    DataNascimento = txtDataNascimento.Value,
                    CPF = txtCPF.Text,
                    QntdDependentes = int.Parse(txtDependentes.Text),
                    Departamento = txtDepartamento.Text,
                };
                //Chama Função de Limpar
                Limpar();
                MessageBox.Show("Itens Salvos com Sucesso!");
            }
            else MessageBox.Show("Preencher Todos os Campos!");
            
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if(obj != null)
            {
                //get
                txtMatricula.Text = obj.Matricula.ToString();
                txtNome.Text = obj.Nome;
                txtCargo.Text = obj.Cargo;
                txtSalario.Text = obj.Salario.ToString();
                txtDataNascimento.Value = obj.DataNascimento;
                txtCPF.Text = obj.CPF;
                txtDependentes.Text = obj.QntdDependentes.ToString();
                txtDepartamento.Text = obj.Departamento;              
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Chama Função de Limpar
            Limpar();
        }

        public void Limpar()
        {
            //Apagar todos os TextBox's
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
            }
        }

        private void btnReajustar_Click(object sender, EventArgs e)
        {
            if(obj != null)
            {
                obj.reajustarSalario(Decimal.Parse(txtPorcentagem.Text));
                MessageBox.Show("Salario Reajustado!");
            }
        }
    }
}
