using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSoma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void soma_Click(object sender, EventArgs e)
        {
            float N1, N2, soma;
            N1 = float.Parse(txtnumero1.Text);
            N2 = float.Parse(txtnumero2.Text);
            soma = N1 + N2;
            MessageBox.Show("A Soma dos Numeros Informados é: " + soma);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            float N1, N2, sub;
            N1 = float.Parse(txtnumero1.Text);
            N2 = float.Parse(txtnumero2.Text);
            sub = N1 - N2;
            MessageBox.Show("A Subtração dos Numeros Informados é: " + sub);
        }

        private void mult_Click(object sender, EventArgs e)
        {
            float N1, N2, mult;
            N1 = float.Parse(txtnumero1.Text);
            N2 = float.Parse(txtnumero2.Text);
            mult = N1 * N2;
            MessageBox.Show("A Multiplicação dos Numeros Informados é: " + mult);
        }

        private void div_Click(object sender, EventArgs e)
        {
            float N1, N2, div;
            N1 = float.Parse(txtnumero1.Text);
            N2 = float.Parse(txtnumero2.Text);
            div = N1 / N2;
            MessageBox.Show("A Divisão dos Numeros Informados é: " + div);
        }
    }
}
