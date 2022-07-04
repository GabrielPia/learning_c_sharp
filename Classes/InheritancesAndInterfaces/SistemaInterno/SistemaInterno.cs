using InheritancesAndInterfaces.Funcionários;

namespace InheritancesAndInterfaces.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(FuncionarioAutenticado funcionario)
        {
            bool usuarioAutenticado = funcionario.Autenticar(funcionario.Login, funcionario.Senha);
            if(usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao Sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
