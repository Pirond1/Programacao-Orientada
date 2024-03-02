using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            bool retorno = validarLogin();
            if (retorno)
            {
                txtEmail.Text = "";
                txtSenha.Text = "";
                FrmPrincipal principal = new FrmPrincipal();
                principal.ShowDialog();
            }
            else
                MessageBox.Show("Dados Invalidos!");
        }

        private bool validarLogin()
        {
            bool retorno = false;

            //ler o Arquivo
            String caminho = "C:\\Users\\gustavopirondi\\Documents\\GitHub\\Programacao-Orientada\\Aula1\\Arquivo\\Dados.txt";
            StreamReader Arquivo = File.OpenText(caminho);
            String linha = "";
            String[] vetor = new string[3]; //Criando um Array de 3 Posições
            while(Arquivo.EndOfStream != true)
            {
                linha = Arquivo.ReadLine();
                vetor = linha.Split('|');
                if (txtEmail.Text == vetor[1] && txtSenha.Text == vetor[2])
                {
                    retorno = true;
                    break;
                }  
            }
            Arquivo.Close();

            return retorno;
        }
    }
}
