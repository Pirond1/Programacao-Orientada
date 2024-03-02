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
        float valorTotal = 0;
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

                valorTotal += valor;
                txtTotal.Text = valorTotal.ToString();

                MessageBox.Show("Produto Adicionado!");
                cbbProduto.SelectedIndex = -1;
                cbbQtde.SelectedIndex = -1;
                txtValor.Text = "";
            }
            else
                MessageBox.Show("Informe o Produto, Quantidade e Valor!");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirmar a Exclusão?", "Exclusão", MessageBoxButtons.YesNo)  == DialogResult.Yes)
            {
                if (lbbProdutos.SelectedIndex != -1)
                {
                    String aux = lbbProdutos.Text;
                    int posicaoInicial = aux.IndexOf("$") + 1;
                    int posicaoFinal = aux.Length;
                    String aux2 = aux.Substring(posicaoInicial, posicaoFinal - posicaoInicial);
                    float valor = float.Parse(aux2.Trim());
                    valorTotal -= valor;
                    txtTotal.Text = valorTotal.ToString();

                    lbbProdutos.Items.RemoveAt(lbbProdutos.SelectedIndex);
                    MessageBox.Show("Item Excluido!");
                }
                else MessageBox.Show("Selecione um Item para Exclusão!");
            }
        }
    }
}
