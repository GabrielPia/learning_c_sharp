namespace bytebank
{
    public class ContaCorrente
    {
        public static int TotalContasCriadas { get; set; }
        private double _saldo;
        private int _numeroAgencia;

        public Cliente Titular { get; set; }

        public string Conta { get; set; }

        public int NumeroAgencia 
        {
            get { return _numeroAgencia; }
            set {
                if (_numeroAgencia <= 0)
                    return;
                _numeroAgencia = value;
            }
        }

        public string NomeAgencia { get; set; }

        public bool Sacar(double valor)
        {
            if (_saldo < valor || valor < 0)
                return false;
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (_saldo < valor || valor < 0)
                return false;
            else
            {
                _saldo -= valor;
                destino._saldo += valor;
                return true;
            }

        }

        public override string ToString()
        {
            return @$"
    Títular - {Titular} 
    Conta - {Conta} 
    Agência - {NumeroAgencia} 
    Nome Agência - {NomeAgencia} 
    saldo - {Saldo} ";
        }

        public double Saldo {
            get { return _saldo; }
            set {
                if (value < 0)
                    return;
                _saldo = value;
            }
        }

        public ContaCorrente(int numeroAgencia, string conta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            Saldo = 0;
            TotalContasCriadas += 1;
        }

    }
}