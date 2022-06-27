namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;


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