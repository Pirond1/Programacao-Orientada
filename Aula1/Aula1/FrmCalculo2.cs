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
    public partial class FrmCalculo2 : Form
    {
        public FrmCalculo2()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lbbNomesAdicionados.Items.Add(txtNome.Text);
            txtNome.Text = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar a Exclusão?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lbbNomesAdicionados.SelectedIndex != -1)
                {
                    lbbNomesAdicionados.Items.RemoveAt(lbbNomesAdicionados.SelectedIndex);
                    MessageBox.Show("Item Excluido!");
                }
                else MessageBox.Show("Selecione um Item para Exclusão!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar a Exclusão?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbbNomesAdicionados.Items.Clear();
                txtNome.Text = "";
                MessageBox.Show("Todos os Itens Removidos!");
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string procurar = (txtNome.Text);
            if(txtNome.Text != "")
            {
                if (lbbNomesAdicionados.Items.Contains(procurar))
                {
                    MessageBox.Show("O nome " + procurar + " foi encontrado!");
                }
                else
                {
                    MessageBox.Show("O nome " + procurar + " não foi encontrado!");
                }
            } 
            else
            {
                MessageBox.Show("Informe um Nome!");
            }
        }
    }
}
