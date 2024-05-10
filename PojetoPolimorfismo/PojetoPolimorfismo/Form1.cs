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

namespace PojetoPolimorfismo
{
    public partial class Form1 : Form
    {
        Pessoa obj;
        public Form1()
        {
            InitializeComponent();
        }
    
        public bool Validador(System.Windows.Forms.Control.ControlCollection controles)
        {
            bool validar = true;
            foreach (var item in controles)
            {
                if(item is TextBox) 
                { 
                    TextBox aux = (TextBox)item;
                    if(aux.Text == "")
                    {
                        MessageBox.Show("CAMPO VAZIO! Preencha " + aux.Tag);
                        aux.BackColor = Color.Red;
                        validar = false;
                    }
                    else
                    {
                        aux.BackColor = Color.White;
                    }
                }
            }
            if(rdbtnGerente.Checked == false && rdbtnHorista.Checked == false) 
            {
                MessageBox.Show("CAMPO VAZIO! Selecione Cargo");
                validar = false;
            }
            return validar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool validar = Validador(ggbPrincipal.Controls);

            if(validar == true) 
            { 
                if(rdbtnHorista.Checked == true)
                {
                    obj = new Pessoa()
                    {
                        Nome = txtNome.Text,
                        Matricula = int.Parse(txtMatricula.Text),
                        RG = txtRG.Text,
                        CPF = txtCPF.Text,
                        DataNascimento = ddtData.Value,
                        QtdHora = Decimal.Parse(txtHorasTrabalhadas.Text),
                        ValorHora = Decimal.Parse(txtValorHora.Text),
                    };
                }
                else if(rdbtnGerente.Checked == true)
                {
                    obj = new Gerente()
                    {
                        Nome = txtNome.Text,
                        Matricula = int.Parse(txtMatricula.Text),
                        RG = txtRG.Text,
                        CPF = txtCPF.Text,
                        DataNascimento = ddtData.Value,
                        QtdHora = Decimal.Parse(txtHorasTrabalhadas.Text),
                        ValorHora = Decimal.Parse(txtValorHora.Text),
                    };
                }
                MessageBox.Show("Informações Salvas com Sucesso!");
            
                foreach (var item in ggbPrincipal.Controls) 
                { 
                    if(item is TextBox)
                    {
                        TextBox aux = (TextBox)item;
                        aux.Text = "";
                    }
                }
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if(obj != null)
            {
                txtNome.Text = obj.Nome;
                txtMatricula.Text = obj.Matricula.ToString();
                txtRG.Text = obj.RG;
                txtCPF.Text = obj.CPF;
                ddtData.Text = obj.DataNascimento.ToString();
                txtHorasTrabalhadas.Text = obj.QtdHora.ToString();
                txtValorHora.Text = obj.ValorHora.ToString();              
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(rdbtnGerente.Checked == true)
            {
                var salarioGerente = obj.CalcularSalario();
                txtSalario.Text = salarioGerente.ToString();
                MessageBox.Show("Salario Calculado!");
            }
            else if (rdbtnHorista.Checked == true)
            {
                var salarioHorista = obj.CalcularSalario();
                txtSalario.Text = salarioHorista.ToString();
                MessageBox.Show("Salario Calculado!");
            }
        }
    }
}
