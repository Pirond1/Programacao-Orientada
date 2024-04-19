using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pessoa
    {
        public String nome {  get; set; }
        public String cpf { get; set; }
        public String telefone { get; set; }
        public int codigo { get; set; }
        public DateTime dtaNascimento { get; set; }
        public String rg { get; set; }
        public String endereco { get; set; }
        public int calcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int diferencaAnos = dataAtual.Year - this.dtaNascimento.Year;
            if(dataAtual.Month < this.dtaNascimento.Month)
            {
                return diferencaAnos - 1;
            }
            else
            {
                if(dataAtual.Month == this.dtaNascimento.Month && dataAtual.Day < this.dtaNascimento.Day)
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
