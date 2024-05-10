using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContaCorrente
    {
        public String numeroAgencia { get; set; }
        public String numeroConta { get; set; }
        public Decimal saldo { get; set; }

        public void Depositar(Decimal valor)
        {
            this.saldo += valor;
        }

        public void Depositar(Decimal valor, DateTime data)
        {
            if (DateTime.Now.Date == data)
            {
                this.saldo += valor;
            }
        }

        public bool Sacar(Decimal valor)
        {
            if (valor <= saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else return false;
        }
    }
}
