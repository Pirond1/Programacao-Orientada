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

namespace ProjetoClasses
{
    public partial class Form1 : Form
    {

        ContaCorrente obj; //Declarando

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var validar = true;

            foreach(var item in ggpConta.Controls) //Validação
            {
                if (item is TextBox)
                {
                    if(((TextBox)item).Text == "")
                        validar = false;
                }
            }

            if (validar == true)
            {
                obj = new ContaCorrente()
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    CPF = (txtCPF.Text),
                    Nome = (txtNome.Text),
                    Saldo = decimal.Parse(txtSaldo.Text),
                };

                Limpar();
            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos!");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Chama Função de Limpar
            Limpar();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if(obj != null)
            {
                txtCodigo.Text = obj.Codigo.ToString();
                txtCPF.Text = obj.CPF.ToString();
                txtNome.Text = obj.Nome.ToString();
                txtSaldo.Text = obj.Saldo.ToString();
            }
        }

        public void Limpar()
        {
            foreach (var item in ggpConta.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";

            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if(obj != null)
            {
                obj.Sacar(decimal.Parse(txtValor.Text));
            }
            else
            {
                MessageBox.Show("Salve o Saldo Inicial!");
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if(obj != null) 
            { 
                obj.Depositar(decimal.Parse(txtValor.Text));
                MessageBox.Show("Depósito Realizado!");            
            }
            else
            {
                MessageBox.Show("Salve o Saldo Inicial!");
            }
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            if(obj != null)
            {
                MessageBox.Show("Saldo Disponível: " + obj.Saldo);
            }
            else
            {
                MessageBox.Show("Salve o Saldo Inicial!");
            }
        }
    }
}
