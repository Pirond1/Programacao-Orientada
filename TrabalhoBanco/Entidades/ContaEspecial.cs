using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContaEspecial:ContaBancaria
    {
        //Propriedades
        public Decimal Limite { get; set; }

        public ContaEspecial(Decimal limite, string Nome, string Conta, Decimal saldo)
        {
            this.Limite = limite;
            this.NomeCliente = Nome;
            this.NumConta = Conta;
            this.Saldo = saldo;
        }

        public ContaEspecial()
        {
            this.Limite = 0;
        }

        //Metodos
        public void SacarSemLimite(Decimal Limite, Decimal ValorSaque)
        {
            if (ValorSaque <= Limite)
            {
                this.Saldo -= this.Saldo - ValorSaque;
                Console.WriteLine("Saque realizado!");
            }
            else
            {
                Console.WriteLine("Valor de saque passa do seu limite de saque, por favor tente um valor dentro do limite!");
            }
        }
    }
}
