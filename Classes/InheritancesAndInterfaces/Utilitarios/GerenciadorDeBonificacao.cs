using InheritancesAndInterfaces.Funcionários;

namespace InheritancesAndInterfaces.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;

        public double getBonificacao()
        {
            return this._totalBonificacao;
        }

        public void Registrar(Funcionario funcionario)
        {
            this._totalBonificacao += funcionario.getBonificacao();
        }

    }
}
