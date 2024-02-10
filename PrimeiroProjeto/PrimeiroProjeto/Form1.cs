using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            idade = int.Parse(textIdade.Text);
            if(idade >= 18){
                MessageBox.Show("Maior de Idade!");
            }
            else{
                MessageBox.Show("Menor de Idade!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
