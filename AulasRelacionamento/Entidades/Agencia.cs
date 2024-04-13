using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agencia
    {
        public String numero {  get; set; }
        public String endereco { get; set; }
        public List<Conta> contas { get; set; }
        public Banco banco { get; set; }
    }
}
