using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gerente:Pessoa
    {
        public override decimal CalcularSalario()
        {
            var salario = (this.ValorHora * 1.15m) * this.QtdHora;
            return salario;
        }
    }
}
