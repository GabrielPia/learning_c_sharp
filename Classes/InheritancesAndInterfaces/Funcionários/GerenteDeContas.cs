using InheritancesAndInterfaces.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesAndInterfaces.Funcionários
{
    public class GerenteDeContas: FuncionarioAutenticado
    {
        public GerenteDeContas(string name, string cpf, double salario): base(name, cpf, salario)
        {
            Console.WriteLine("Criando novo gerente de contas");
        }

        public override double getBonificacao()
        {
            return Salario * 0.25;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.05;
        }

    }
}
