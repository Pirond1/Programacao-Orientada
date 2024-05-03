using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Entidades
{
    public class Funcionario
    {
        public int matricula { get; set; }
        public String nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public Decimal valorHora { get; set; }
        public String cargo { get; set; }
        public String status { get; set; }

        public Decimal totalSalario(int totalHoras)
        {
            Decimal salario = this.valorHora * totalHoras;
            return salario;
        }
        public void ajustarValorHora(int porcent)
        {
            this.valorHora = this.valorHora + (this.valorHora * porcent/100);
        }

    }
}
