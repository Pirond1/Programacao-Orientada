using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class FrmCadastro : Form
    {
        string salvargenero;
        string salvarlinguagem = "";

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbEstado.SelectedIndex.ToString());
            cbbCidade.Items.Clear();
            switch (cbbEstado.SelectedIndex)
            {
                case 0:
                    //São Paulo
                    cbbCidade.Items.Add("São Paulo");
                    cbbCidade.Items.Add("Campinas");
                    cbbCidade.Items.Add("Osasco");
                    cbbCidade.Items.Add("Presidente Prudente");
                    cbbCidade.Items.Add("Alvarez Machado");
                    cbbCidade.Items.Add("Presidente Epitácio");
                    break;
                case 1:
                    //Rio de Janeiro
                    cbbCidade.Items.Add("Rio de Janeiro");
                    cbbCidade.Items.Add("Niterói");
                    cbbCidade.Items.Add("Petrópoles");
                    break;
                case 2:
                    //Minas Gerais
                    cbbCidade.Items.Add("Belo Horizonte");
                    cbbCidade.Items.Add("Formiga");
                    cbbCidade.Items.Add("Poços de Calda");
                    break;
                default:
                    break;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string validar = "";
            string resumo = "";
            if(txtNome.Text == "")
                validar = "Informar o Nome!";
            else
                resumo = "Nome: " + txtNome.Text;

            if (txtEmail.Text == "")
                validar += "\r\nInformar o E-mail!";
            else
                resumo += "\r\nE-mail: " + txtEmail.Text;

            if (txtSenha.Text == "")
                validar += "\r\nInformar a Senha!";
            else
                resumo += "\r\nSenha: " + txtSenha.Text;

            if (cbbEstado.Text == "")
                validar += "\r\nInformar o Estado!";
            else
                resumo += "\r\nEstado: " + cbbEstado.Text;

            if (txtDataNascimento.Text == "")
                validar += "\r\nInformar a Data de Nascimento!";
            else
                resumo += "\r\nData de Nascimento : " + txtDataNascimento.Text;

            if (cbbCidade.Text == "")
                validar += "\r\nInformar a Cidade!";
            else
                resumo += "\r\nCidade : " + cbbCidade.Text;

            if (rbtFeminino.Checked || rbtMasculino.Checked || rbtInformar.Checked)
            {
                if (rbtFeminino.Checked)
                {
                    resumo += "\r\nGênero : Feminino";
                    salvargenero = "Feminino";
                }
                else
                    if (rbtMasculino.Checked)
                    {
                        resumo += "\r\nGênero : Masculino";
                        salvargenero = "Masculino";
                    }
                    else
                    {
                        resumo += "\r\nGênero : Não Informar";
                        salvargenero = "Não Informar";
                    }       
            }
            else
                validar += "\r\nInformar o Gênero!";

            if (clbLinguagens.CheckedItems.Count > 0)
            {
                resumo += "\r\nLinguagens : ";
                for (int i = 0; i < clbLinguagens.CheckedItems.Count; i++)
                {
                    resumo += clbLinguagens.CheckedItems[i].ToString() + ", ";
                    salvarlinguagem += clbLinguagens.CheckedItems[i].ToString() + "-";
                }
            }
            else
                validar += "\r\nInformar as Linguagens!";

            if (validar != "")
                MessageBox.Show(validar);
            else
            {
                txtResumo.Text = resumo;
                gravarArquivo();
                txtNome.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                cbbEstado.SelectedIndex = -1;
                cbbCidade.SelectedIndex = -1;
                rbtFeminino.Checked = false;
                rbtMasculino.Checked = false;
                rbtInformar.Checked = false;
                for(int i = 0; i < clbLinguagens.Items.Count; i++)
                {
                    clbLinguagens.SetSelected(i, false);
                    clbLinguagens.SetItemChecked(i, false);
                }
            }
        }

        public void gravarArquivo()
        {
            String caminho = "C:\\Users\\gustavopirondi\\Documents\\GitHub\\Programacao-Orientada\\Aula1\\Arquivo\\Dados.txt";
            StreamWriter Arquivo = null;
            if(!File.Exists(caminho))
                Arquivo = File.CreateText(caminho); //Criar
            else
                Arquivo = File.AppendText(caminho); //Ja Existe
            Arquivo.WriteLine(txtNome.Text + "|" + txtEmail.Text + "|" + txtSenha.Text + "|" + txtDataNascimento.Text + "|" + cbbEstado.Text + "|" + cbbCidade.Text + "|" + salvargenero + "|" + salvarlinguagem);
            Arquivo.Close();
        }
    }
}
