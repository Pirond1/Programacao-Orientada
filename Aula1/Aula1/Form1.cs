using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validar os dados
            if (txtEmail.Text == "admin@admin.com" && txtSenha.Text == "123456")
            {
                txtEmail.Text = "";
                txtSenha.Text = "";
                FrmPrincipal principal = new FrmPrincipal();
                principal.ShowDialog();
            }
            else
                MessageBox.Show("Dados Invalidos!");
        }
    }
}
