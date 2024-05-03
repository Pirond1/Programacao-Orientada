using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoHeranca
{
    public partial class Form1 : Form
    {

        Funcionario obj;

        public Form1()
        {
            InitializeComponent();
        }

        public bool validarCampos(System.Windows.Forms.Control.ControlCollection controles)
        {
            bool validar = true;
            foreach (var item in controles)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox aux = (System.Windows.Forms.TextBox)item;
                    if (aux.Text == "")
                    {
                        MessageBox.Show("Preencha o campo: " + aux.Tag);
                        aux.BackColor = Color.OrangeRed;
                        validar = false;
                    }
                    else
                        aux.BackColor = Color.White;
                }
            }
            return validar;
        }

        public void limparCampos()
        {
            foreach (var item in gbDados.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox aux = (System.Windows.Forms.TextBox)item;
                    aux.Text = "";
                }
            }

            foreach (var item in groupBox1.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox aux = (System.Windows.Forms.TextBox)item;
                    aux.Text = "";
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Funcionario objFunc = new Funcionario()
            {
                cargo = "Analista",
                dataNascimento = DateTime.Now,
                matricula = 123,
                nome = "Gustavo",
                status = "Ativo",
                valorHora = 50
            };

            Gerente objGere = new Gerente()
            {
                cargo = "Gerente",
                dataNascimento = DateTime.Now,
                matricula = 321,
                nome = "Eduardo",
                status = "Ativo",
                valorHora = 100,
                valorComissao = 10,
                qtdFuncionarios = 11
            };



        }

        private void ckGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGerente.Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool validar = validarCampos(gbDados.Controls);

            if (validar) //Genérico
            {
                if (ckGerente.Checked)
                {

                    validar = validarCampos(groupBox1.Controls); //Caso Gerente

                    if (validar)
                    {
                        obj = new Gerente()
                        {
                            cargo = txtCargo.Text,
                            dataNascimento = txtDataNascimento.Value,
                            matricula = int.Parse(txtMatricula.Text),
                            nome = txtNome.Text,
                            status = txtStatus.Text,
                            valorHora = Decimal.Parse(txtValorHora.Text),
                            valorComissao = Decimal.Parse(txtComissao.Text),
                            qtdFuncionarios = int.Parse(txtQtdFuncionario.Text),
                        };
                        MessageBox.Show("Dados Salvos com Sucesso!");
                    }
                }
                else
                {
                    obj = new Funcionario()
                    {
                        cargo = txtCargo.Text,
                        dataNascimento = txtDataNascimento.Value,
                        matricula = int.Parse(txtMatricula.Text),
                        nome = txtNome.Text,
                        status = txtStatus.Text,
                        valorHora = Decimal.Parse(txtValorHora.Text),
                    };
                    MessageBox.Show("Dados Salvos com Sucesso!");
                }
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                txtCargo.Text = obj.cargo;
                txtDataNascimento.Value = obj.dataNascimento;
                txtMatricula.Text = obj.matricula.ToString();
                txtNome.Text = obj.nome;
                txtStatus.Text = obj.status;
                txtValorHora.Text = obj.valorHora.ToString();

                if (obj is Gerente)
                {
                    Gerente aux = (Gerente)obj;
                    txtComissao.Text = aux.valorComissao.ToString();
                    txtQtdFuncionario.Text = aux.qtdFuncionarios.ToString();
                }


            }
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                if (txtTotalHoras.Text != "")
                {
                    Decimal salario = obj.totalSalario(int.Parse(txtTotalHoras.Text));
                    MessageBox.Show("Salario é: " + salario);
                }
                else
                {
                    MessageBox.Show("Informe o Total de Horas");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                if (txtPorcentagemHora.Text != "")
                {
                    obj.ajustarValorHora(int.Parse(txtPorcentagemHora.Text));
                    MessageBox.Show("Valor Atualizado para: " + obj.valorHora);
                }
                else
                {
                    MessageBox.Show("Informe a % do Valor da Hora!");
                }
            }
        }
        private void btnCalcularSalarioComissao_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                if (txtTotalHorasComissao.Text != "")
                {
                    if (obj is Gerente)
                    {
                        Gerente aux = (Gerente)obj;
                        Decimal salario = aux.calcularSalarioComComissao(int.Parse(txtTotalHorasComissao.Text));
                        MessageBox.Show("Salário Comissionado é: " + salario);
                    }
                }
            }
        }

        private void btnValorComissaoNovo_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                if (txtPorcentagemComissao.Text != "")
                {
                    if (obj is Gerente)
                    {
                        Gerente aux = (Gerente)obj;
                        aux.ajustarValorComissão(int.Parse(txtPorcentagemComissao.Text));
                        MessageBox.Show("Valor Atualizado para: " + aux.valorComissao);
                    }
                }
                else
                {
                    MessageBox.Show("Informe a % da Comissão!");
                }
            }
        }
    }
}