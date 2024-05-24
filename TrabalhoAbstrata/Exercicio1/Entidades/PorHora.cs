using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PorHora:Empregado
    {
        public Decimal valorPorHora { get; set; }

        public override bool calcularSalario(Decimal totalHoras)
        {
            if (this.valorPorHora >= 0 && totalHoras != 0)
            {
                this.salario = this.valorPorHora * totalHoras;

                return true;
            }
            else { return false; }
        }
    }
}
