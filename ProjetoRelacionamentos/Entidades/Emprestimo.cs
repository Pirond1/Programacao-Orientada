using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Emprestimo
    {
        public int codigoAluno { get; set; }
        public int codigoFuncionario { get; set; }
        public int codgioLivro { get; set; }
        public DateTime dtaRetirada { get; set; }
        public DateTime dtaDevolucao { get; set; }
        public Decimal multa { get; set; }
        public List<Livro> livro { get; set; }
        public Funcionario funcionario { get; set; }
        public Aluno aluno { get; set; }

        public void verificarMulta()
        {
            DateTime dataAtual = DateTime.Now;
            if(dataAtual.Month > this.dtaDevolucao.Month)
            {
                calcularMulta();
            }
            else
            {
                if(dataAtual.Month == this.dtaDevolucao.Month && dataAtual.Day > dtaDevolucao.day)
                {
                    calcularMulta();
                }
            }
        }
        public Decimal calcularMulta()
        {
            DateTime dataAtual = DateTime.Now;
            int diferencaTempoMes = dataAtual.Month - this.dtaDevolucao.Month;
            int diferencaTempoDia = dataAtual.Day - this.dtaDevolucao.Day;

            int diferencaTempo = (diferencaTempoMes * 30 + diferencaTempoDia);

            Decimal valorMulta = (diferencaTempo * this.multa);
            return valorMulta;
        }
    }
}
