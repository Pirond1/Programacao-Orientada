using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Retangulo:IFigura
    {
        public Decimal basee { get; set; }
        public Decimal altura { get; set; }

        public decimal calcularArea()
        {
            Decimal area;
            area = basee * altura;
            return area;
        }

        public decimal calcularPerimetro()
        {
            Decimal perimetro;
            perimetro = 2 * (basee + altura);
            return perimetro;
        }
    }
}
