using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        public String id { get; set; }
        public String endereco { get; set; }
        public String telefone { get; set; }
        public int qtdLivros { get; set; }
        public int qtdFuncionarios { get; set; }
        public List<Funcionario> funcionarios { get; set; }
        public List<Livro> livro { get; set; }
    }
}
