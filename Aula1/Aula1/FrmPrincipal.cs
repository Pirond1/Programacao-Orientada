﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void calculo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculo1 calculo1 = new FrmCalculo1();
            calculo1.ShowDialog();
        }

        private void calculo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculo2 calculo2 = new FrmCalculo2();
            calculo2.ShowDialog();
        }
    }
}
