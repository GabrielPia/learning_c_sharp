using InheritancesAndInterfaces.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesAndInterfaces.ParceriaComercial
{
    public class ParceiroComercial: IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string login, string senha)
        {
            if (this.Senha != senha || this.Login != login)
            {
                Console.WriteLine("Login ou senha incorretos.");
                return false;
            }
            Console.WriteLine("Bem vindos ao sistema");
            return true;
        }
    }
}
