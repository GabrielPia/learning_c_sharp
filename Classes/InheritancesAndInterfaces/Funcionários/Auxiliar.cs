

namespace InheritancesAndInterfaces.Funcionários
{
    internal class Auxiliar: Funcionario
    {
        public Auxiliar(string nome, string cpf, double salario): base(nome, cpf, salario)
        {
            Console.WriteLine("Criando novo auxiliar");
        }

        public override double getBonificacao()
        {
            return Salario * 0.2;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
