using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empregado
    {
        public int matricula { get; set; }
        public String nome { get; set; }
        public Decimal salario { get; set; }

        public Empregado()
        {
            this.salario = 0;
        }

        public Empregado(int matricula, String nome, Decimal salario)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.salario = salario;
        }

        public abstract bool calcularSalario(Decimal valor);
    }
}
