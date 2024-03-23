using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funcionario
    {
        public int Matricula { get; set; }

        public String Nome { get; set; }
        
        public String Cargo { get; set; }
        
        public Decimal Salario { get; set; }
        
        public DateTime DataNascimento { get; set; }
        
        public String CPF { get; set; }
        
        public int QntdDependentes { get; set; }
    
        public String Departamento { get; set; }
    

        public void reajustarSalario(Decimal porcentagem)
        {
            this.Salario = this.Salario + (this.Salario * porcentagem/100);
        }

    }
}
