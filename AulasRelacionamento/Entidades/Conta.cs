using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Conta
    {
        public String numero { get; set; }
        public Decimal saldo { get; set; }
        public DateTime dataAbertura { get; set; }
        public Decimal valorLimite { get; set; }
        public Cliente cliente { get; set; }
        public Agencia agencia { get; set; }
        public List<ServicosConta> servicoscontas {  get; set; }

        public void Depositar (Decimal valor)
        {
            this.saldo += valor;
        }

        public bool Sacar (Decimal valor)
        {
            if (valor > this.saldo)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }
    }
}
