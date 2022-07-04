using InheritancesAndInterfaces.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesAndInterfaces.Funcionários
{
    public abstract class FuncionarioAutenticado : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticado(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string login, string senha)
        {
            if(this.Senha != senha || this.Login != login){
                Console.WriteLine("Login ou senha incorretos.");
                return false;
            }
            Console.WriteLine("Bem vindos ao sistema");
            return true;
        }
    }
}
