using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesAndInterfaces.Funcionários
{
    public class Designer: Funcionario
    {
        public Designer(string name, string cpf, double salario): base(name, cpf, salario)
        {
            Console.WriteLine("Criando novo designer");
        }

        public override double getBonificacao()
        {
            return Salario * 0.17;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
