using InheritancesAndInterfaces.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesAndInterfaces.Funcionários
{
    public class Diretor : FuncionarioAutenticado
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override double getBonificacao()
        {
            return Salario * 0.5;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
