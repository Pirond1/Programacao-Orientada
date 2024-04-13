using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Pessoa
    {
        public int codigoCliente { get; set; }
        public List<Conta> contas { get; set; }
    }
}
