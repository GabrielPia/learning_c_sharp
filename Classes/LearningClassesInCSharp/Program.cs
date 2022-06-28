using bytebank;

Console.WriteLine("Boas Vindas as seu Banco, ByteBank!");

bool stop = false;

while(!stop)
{
    Console.WriteLine("\n********************************************\n");
    Console.WriteLine("Escolha uma opção abaixo para prosseguir");
    Console.WriteLine("1 - Cadastrar nova conta");
    Console.WriteLine("2 - Verificar dados da conta");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("\n********************************************\n");
    string option = Console.ReadLine().ToString();


    switch(option)
    {
        case "1":
            Console.WriteLine("Cadastrando nova conta: "); 
            ContaCorrente novaConta = new ContaCorrente(23, "10123-X");
            Cliente titular = new Cliente();
            titular.Nome = "Gabriel Martins Teixeira Piagentini";
            titular.Cpf = "123.456.789.00";
            titular.Profissao = "Programador C#";
            novaConta.Titular = titular;
            novaConta.NomeAgencia = "Agencia Central";
            novaConta.Saldo = 93.50;
            
            break;
        case "2":
            Console.WriteLine("Verificando conta: ");

            break;
        case "3":
            Console.WriteLine("Obrigado por utilizar: ");
            stop = true;
            break;
        default:
            Console.WriteLine("Opção não encontrada");
            break;
    }
}

Console.ReadKey();
