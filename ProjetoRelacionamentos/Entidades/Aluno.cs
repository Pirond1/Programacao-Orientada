using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aluno:Pessoa
    {
        public String curso { get; set; }
        public List<Emprestimo> emprestimo { get; set;}
    }
}
