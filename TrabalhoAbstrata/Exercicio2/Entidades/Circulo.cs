using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Circulo:IFigura
    {
        public Decimal raio { get; set; }

        public decimal calcularArea()
        {
            Decimal area;
            Decimal pi = 3.14M;
            area = pi * (this.raio * this.raio);
            return area;
        }

        public decimal calcularPerimetro()
        {
            Decimal perimetro;
            Decimal pi = 3.14M;
            perimetro = 2 * pi * this.raio;
            return perimetro;
        }
    }
}
