using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Chefe:Empregado
    {
        public Decimal salarioFixo { get; set; }

        public override bool calcularSalario(Decimal predefinido)
        {
            if (this.salario >= 0 && predefinido >= 0)
            {
                this.salario += this.salarioFixo + predefinido;
                return true;
            }
            else { return false; }
        }
    }
}
