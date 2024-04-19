using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Livro
    {
        public int codigo { get; set; }
        public String nome { get; set; }
        public String autor { get; set; }
        public String idioma { get; set; }
        public String tema { get; set; }
        public int paginas { get; set; }
        public int quantidade { get; set; }
        public Biblioteca biblioteca { get; set; }
        public List<Emprestimo> emprestimos { get; set; }
    }
}
