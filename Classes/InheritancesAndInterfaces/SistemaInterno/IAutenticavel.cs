using InheritancesAndInterfaces.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesAndInterfaces.SistemaInterno
{
    public interface IAutenticavel
    {
        public bool Autenticar(string login, string senha);

    }
}
