using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funcionario:Pessoa
    {
        public String cargo { get; set; }
        public String setor { get; set; }
        public Decimal cargaHoraria { get; set; }
        public Decimal salario { get; set; }
        public String email { get; set; }
        public Biblioteca biblioteca { get; set; }
        public List<Emprestimo> emprestimo { get; set; }
    }
}
