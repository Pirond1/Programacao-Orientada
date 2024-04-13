using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ServicosConta
    {
        public int codigo { get; set; }
        public DateTime data { get; set; }
        public Decimal valor { get; set; }
        public int qtdparcelas { get; set; }
        public Servicos servicos { get; set; }
        public Conta conta { get; set; }
    }
}
