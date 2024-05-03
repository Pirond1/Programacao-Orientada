using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContaBancaria
    {
        //Propriedades
        public string NomeCliente { get; set; }
        public string NumConta { get; set; }
        public decimal Saldo { get; set; }
        public Decimal Valor { get; set; }

        public ContaBancaria(string Nome, string Conta, decimal saldo)
        {
            this.NomeCliente = Nome;
            this.NumConta = Conta;
            this.Saldo = saldo;
        }

        public ContaBancaria(){
            this.NomeCliente = "";
            this.NomeCliente = "";
            this.Saldo = 0;
        }

        //Metodos
        public Decimal Sacar(decimal ValorSaque)
        {
            decimal valida = 0;   
            if (this.Saldo <= 0 || this.Saldo < ValorSaque)
            {
                return valida;
            }
            else
            {
                this.Saldo -= ValorSaque;
                valida = 1;
                return valida;
            }
        }

        public void Depositar(decimal ValorDeposito)
        {
            this.Saldo += ValorDeposito;
            Console.WriteLine("Valor depositado com sucesso, seu saldo agora é: " + this.Saldo);

        }
    }
}
