using System.Runtime.Serialization;
using static System.Console;
DateTime data = DateTime.Now;

string entrada;
int turistas=0, total=0, contagem;

WriteLine("Aplicativo de controle de fluxo de carros");
WriteLine("Parque Nacional os Lençóis Maranhenses\n");

while (true)
{
    WriteLine("Digite o fluxo de carro (entrada/saida) ou sair para encerrar a aplicação: ");
    entrada = ReadLine();
    
    if (entrada == "entrada")
    {
        Write("Digite o número de turistas: ");
        turistas = int.Parse(ReadLine());
        contagem = total + turistas;
        WriteLine($"Entrada de turistas registrada em: {data:dd/MM;yyyy hh:mm:ss}");
        WriteLine($"Número de turistas no parque: {turistas}");
    }
    if (entrada == "saida")
    {
        Write("Digite o número de turistas: ");
        turistas = int.Parse(ReadLine());
        contagem = total - turistas;
        WriteLine($"Saída de turistas registrada em: {data:dd/MM;yyyy hh:mm:ss}");
        WriteLine($"Número de turistas no parque: {contagem}");
    }
    if (entrada == "sair")
    {
        WriteLine("Encerrando programa.");
        break;
    }
    else
    {
        WriteLine("ERRO: Digite um dos comandos citados anteriormente");
    }
}