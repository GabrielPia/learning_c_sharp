using InheritancesAndInterfaces.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesAndInterfaces.Funcionários
{
    public abstract class Funcionario
    {

        public Funcionario(string nome, string cpf, double salario)
        { 
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        public static int TotalFuncionarios { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public abstract double getBonificacao();

        public abstract void aumentarSalario();


    }
}
