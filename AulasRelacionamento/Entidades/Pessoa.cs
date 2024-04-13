using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pessoa
    {
        public int codigo { get; set; }
        public String nome { get; set; }
        public String cpf { get; set; }
        public DateTime dtNascimento { get; set; }
        public int calcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int diferencaAnos = dataAtual.Year - this.dtNascimento.Year;
            if (dataAtual.Month < this.dtNascimento.Month)
            {
                return diferencaAnos - 1;
            }
            else
            {
                if (dataAtual.Month == this.dtNascimento.Month && dataAtual.Day < this.dtNascimento.Day)
                {
                    return diferencaAnos - 1;
                }
                else
                {
                    return diferencaAnos;
                }
            }
        }
    }
}
