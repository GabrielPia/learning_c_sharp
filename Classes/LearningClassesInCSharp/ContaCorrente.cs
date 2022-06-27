namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;


        public bool sacar(double valor)
        {
            if (saldo < valor || valor < 0)
                return false;
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void depositar(double valor)
        {
            if (valor > 0)
                saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor || valor < 0)
                return false;
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }

        }

        public override string ToString()
        {
            return @$"
    Títular - {titular} 
    Conta - {conta} 
    Agência - {numeroAgencia} 
    Nome Agência - {nomeAgencia} 
    saldo - {saldo} ";
        }
    }
}