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
    public partial class FrmCalculo1 : Form
    {
        public FrmCalculo1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cbbProduto.Text != "" && cbbQtde.Text != "" && txtValor.Text != "")
            {
                float valor = float.Parse(cbbQtde.Text) * float.Parse(txtValor.Text);
                lbbProdutos.Items.Add(cbbProduto.Text + " / " + cbbQtde.Text + " / R$ " + valor);
                MessageBox.Show("Produto Adicionado!");
                cbbProduto.SelectedIndex = -1;
                cbbQtde.SelectedIndex = -1;
                txtValor.Text = "";
            }
            else
                MessageBox.Show("Informe o Produto, Quantidade e Valor!");
        }
    }
}
