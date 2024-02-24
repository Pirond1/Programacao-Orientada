using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class FrmCadastro : Form
    {
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
                    resumo += "\r\nGênero : Feminino";
                else 
                    if (rbtMasculino.Checked)
                        resumo += "\r\nGênero : Masculino";
                        else 
                            resumo += "\r\nGênero : Não Informar";
            }
            else
                validar += "\r\nInformar o Gênero!";

            if (clbLinguagens.CheckedItems.Count > 0)
            {
                resumo += "\r\nLinguagens : ";
                for (int i = 0; i < clbLinguagens.CheckedItems.Count; i++)
                {
                    resumo += clbLinguagens.CheckedItems[i].ToString() + ", ";
                }
            }
            else
                validar += "\r\nInformar as Linguagens!";

            if (validar != "")
                MessageBox.Show(validar);
            else
                txtResumo.Text = resumo;

        }
    }
}
