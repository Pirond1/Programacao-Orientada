using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses.Classes
{
    public class ContaCorrente
    {
        //Propriedades
        public int Codigo { get; set; }
        public float Saldo { get; set; }
        public String Nome { get; set; }
        public String Senha { get; set; }

        //Metodos
        public float Sacar(float valor)
        {
            if (Saldo >= valor) 
            {
                Saldo -= valor;
            }
            return Saldo;
        }

        public float Depositar(float valor)
        {
            Saldo += valor;
            return Saldo;
        }
    }
}
