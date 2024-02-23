using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDisciplina.Items.Clear();
            switch(cbbCurso.SelectedIndex)
            {
                case 0:
                    //Administração
                    cbbDisciplina.Items.Add("Gestão de Pessoas");
                    cbbDisciplina.Items.Add("Gestão Imobiliaria");
                    cbbDisciplina.Items.Add("Gestão de Negócios");
                    break;
                case 1:
                    //Contabeis
                    cbbDisciplina.Items.Add("Contabilidade Básica");
                    cbbDisciplina.Items.Add("Contabilidade Gerencial");
                    cbbDisciplina.Items.Add("Contabilidade Avançada");
                    break;
                case 2:
                    //Sistemas de Informação
                    cbbDisciplina.Items.Add("Algoritimos");
                    cbbDisciplina.Items.Add("Programação Web");
                    cbbDisciplina.Items.Add("Banco de Dados");
                    break;
            }
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            string validar = "";
            if(txtNome.Text == ""){
                validar = "Informe seu Nome!";
            }
            if(txtEndereco.Text == ""){
                validar += "\nInforme seu Endereço!";
            }
            if(txtCidade.Text == ""){
                validar += "\nInforme sua Cidade!";
            }
            if(txtEstado.Text == ""){
                validar += "\nInforme seu Estado!";
            }
            if(txtIdade.Text == ""){
                validar += "\nInforme sua Data de Nascimento!";
            }
            if(cbbCurso.Text == ""){
                validar += "\nInforme seu Curso!";
            }
            if(cbbDisciplina.Text == ""){
                validar += "\nInforme sua Disciplina!";
            }

            if(validar == ""){
                txtNome.Clear();
                txtEndereco.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
                
                cbbCurso.SelectedIndex = -1;
                cbbDisciplina.SelectedIndex = -1;
                MessageBox.Show("Matricula Enviada!");
            }
            if (validar != "")
                MessageBox.Show(validar);
        }
    }
}
