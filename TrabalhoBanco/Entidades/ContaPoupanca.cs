using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContaPoupanca: ContaBancaria
    {
        //Propriedades
        public int DiadeRendimento { get; set; }
        public decimal TaxadeRendimento { get; set; }

        public ContaPoupanca(int Rendimento, decimal TaxaRendimento, string Nome, string Conta, decimal saldo)
        {
            this.DiadeRendimento = Rendimento;
            this.TaxadeRendimento = TaxaRendimento;
            this.NomeCliente = Nome;
            this.NumConta = Conta;
            this.Saldo = saldo;
        }
        public ContaPoupanca()
        {
            //this.DiadeRendimento = ;
            this.TaxadeRendimento = 0;
        }

        //Metodos

        public void CalcularNovoSaldo(decimal TaxadeRendimento, int DiadeRendimento)
        {
            int diaAtual = DateTime.Now.Day;

            if (diaAtual < DiadeRendimento)
            {
                Console.WriteLine("Rendimento não disponivel ainda");
            }
            else
            {
                this.Saldo = this.Saldo * TaxadeRendimento / 100;
               Console.WriteLine($"Saldo atualizado com sucesso! {Saldo}");
            }
        }
    }
}
