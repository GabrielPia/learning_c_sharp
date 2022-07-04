using InheritancesAndInterfaces.Funcionários;
using InheritancesAndInterfaces.Utilitarios;

Console.WriteLine("Boas Vindas!");

void CalcularBonificacoes()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    Diretor pedro = new Diretor("Pedro", "123.456.789.00", 5000);
    Designer paula = new Designer("Paula", "123.456.789.00", 3000);
    Auxiliar igor = new Auxiliar("Igor", "123.456.789.00", 2000);
    GerenteDeContas camila = new GerenteDeContas("Camila", "123.456.789.00", 4000);

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine($"Bonificação Total: {gerenciador.getBonificacao()}");
}

CalcularBonificacoes();

Console.ReadKey();
