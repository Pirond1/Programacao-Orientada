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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Santander
{
    public partial class Form1 : Form
    {
        ContaBancaria obj;
        ContaPoupanca obj1;
        ContaEspecial obj2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var Validando = true;

            foreach (var item in ggpTerminal.Controls) //validando os campos
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Text == "")
                        Validando = false;
                }
            }


            if(Validando == true)
            {
                if(obj != null)
                {
                    obj = new ContaBancaria()
                    {
                        NomeCliente = (txtNome.Text),
                        NumConta = (txtConta.Text),
                        Saldo = decimal.Parse(txtSaldo.Text),
                        Valor = decimal.Parse(txtValor.Text),
                    };
                    
                }


                if (ckPoupanca.Checked)
                {
                    obj1 = new ContaPoupanca()
                    {
                        NomeCliente = (txtNome.Text),
                        NumConta = (txtConta.Text),
                        Saldo = decimal.Parse(txtSaldo.Text),
                        Valor = decimal.Parse(txtValor.Text),
                        DiadeRendimento = int.Parse(txtDiaRendimento.Text),
                        TaxadeRendimento = decimal.Parse(txtDiaRendimento.Text),
                    };
                }
                else
                {
                    obj2 = new ContaEspecial()
                    {
                        NomeCliente = (txtNome.Text),
                        NumConta = (txtConta.Text),
                        Saldo = decimal.Parse(txtSaldo.Text),
                        Valor = decimal.Parse(txtValor.Text),
                        Limite = decimal.Parse(txtLimite.Text),
                    };
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os campos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            foreach (var item in ggpTerminal.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {

            if(obj != null)
            {
                if (ckEspecial.Checked)
                {
                    obj2.SacarSemLimite(decimal.Parse(txtLimite.Text), decimal.Parse(txtValor.Text));
                    MessageBox.Show("Saque realizado!" + obj.Saldo);
                }

                else
                {
                    obj.Sacar(decimal.Parse(txtValor.Text));
                    MessageBox.Show("Saque realizado com sucesso, seu saldo agora é: " + obj.Saldo);
                }
            }
           
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            obj.Depositar(decimal.Parse(txtValor.Text));
            MessageBox.Show("Valor depositado com sucesso, seu saldo agora é: " + obj.Saldo);

        }

        private void ckPoupanca_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPoupanca.Checked)
                ggpPopupanca.Visible = true;
            else
                ggpPopupanca.Visible = false;
            
        }

        private void btnCalcSaldo_Click(object sender, EventArgs e)
        {
            obj1.CalcularNovoSaldo(decimal.Parse(txtTaxaRendimento.Text), int.Parse(txtDiaRendimento.Text));
        }

        private void ckEspecial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckEspecial.Checked)
                ggpEspecial.Visible = true;
            else
                ggpEspecial.Visible = false;
        }
    }
}
