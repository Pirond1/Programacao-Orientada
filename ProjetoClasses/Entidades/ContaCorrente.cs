using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContaCorrente
    {
            //Propriedades
            public int Codigo { get; set; }
            public Decimal Saldo { get; set; }
            public Decimal Valor { get; set; }
            public String Nome { get; set; }
            public String CPF { get; set; }

            //Metodos
            public void Sacar(Decimal valor)
            {
                if (this.Saldo >= valor)
                {
                    Saldo -= valor;
                    MessageBox.Show("Saque Realizado!");
            }
                else
                {
                    MessageBox.Show("Saldo Insuficiente!");
                }
            }

            public void Depositar(Decimal valor)
            {
                Saldo += valor;
            }
    }
}
