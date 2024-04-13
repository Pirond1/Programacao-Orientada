using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banco
    {
        public String numero { get; set; }
        public String cnpj { get; set; }
        public String nome { get; set; }
        public virtual List<Agencia> agencia { get; set; }
    }
}
