using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public int Matricula {  get; set; }
        public String RG {  get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public Decimal QtdHora { get; set; }
        public Decimal ValorHora { get; set; }

        public virtual Decimal CalcularSalario()
        {
            Decimal salario =  this.ValorHora * this.QtdHora;
            return salario;
        }
    }
}
