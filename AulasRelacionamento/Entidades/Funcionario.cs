using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funcionario:Pessoa
    {
        public int matricula {  get; set; }
        public Decimal salario { get; set; }
        public DateTime dataAdmissao { get; set; }
        public String cargo { get; set; }
    }
}
