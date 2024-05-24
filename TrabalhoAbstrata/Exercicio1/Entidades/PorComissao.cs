using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PorComissao:Empregado
    {
        public Decimal valorFixo { get; set; }
        public int vendas { get; set; }

        public override bool calcularSalario(Decimal comissao)
        {
            if (this.valorFixo >= 0 && this.vendas != 0)
            {
                this.salario = this.valorFixo + (comissao * this.vendas);

                return true;
            }
            else { return false; }
        }
    }
}
