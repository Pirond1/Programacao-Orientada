﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAdicionar.Text == "")
                MessageBox.Show("Informe Algo para Salvar!");

            else
                cbbAdicionado.Items.Add(txtAdicionar.Text);
                txtAdicionar.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cbbAdicionado.Items.Clear();
        }
    }
}
