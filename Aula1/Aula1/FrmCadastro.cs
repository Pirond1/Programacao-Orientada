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
            //Terminar de Validar!!!

            if (validar != "")
                MessageBox.Show(validar);
            else
                txtResumo.Text = resumo;

        }
    }
}
