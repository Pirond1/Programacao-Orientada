using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicos
    {
        public int codigo { get; set; }
        public String nome { get; set; }
        public String tipo { get; set; }
        public String nivel { get; set; }
        public virtual List<ServicosConta> servicoscontas { get; set; }
    }
}
