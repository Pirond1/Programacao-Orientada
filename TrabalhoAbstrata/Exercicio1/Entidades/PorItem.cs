using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PorItem:Empregado
    {
        public Decimal valorPorProducao { get; set; }

        public override bool calcularSalario(Decimal quantidade)
        {
            if (this.valorPorProducao >= 0 && quantidade != 0)
            {
                this.salario = this.valorPorProducao * quantidade;

                return true;
            }
            else { return false; }
        }
    }
}
