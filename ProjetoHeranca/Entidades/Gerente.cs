using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gerente:Funcionario
    {
        public Decimal valorComissao {  get; set; }
        public int qtdFuncionarios { get; set; }

        public void ajustarValorComissão(int porcent)
        {
            this.valorComissao = this.valorComissao + (this.valorComissao * porcent/100);
        }
        public Decimal calcularSalarioComComissao(int totalHoras)
        {    
            Decimal salario = totalSalario(totalHoras);
            Decimal salarioComissao = salario + (this.valorComissao * this.qtdFuncionarios);
            return salarioComissao;
        }
    }
}
