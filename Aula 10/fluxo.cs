using static System.Console;
DateTime data = DateTime.Now;

string entrada;
int turistas=0, contagem = 0;

WriteLine("Aplicativo de controle de fluxo de carros");
WriteLine("Parque Nacional os Lençóis Maranhenses\n");

while (true)
{
    Write("Digite o fluxo de carro (entrada/saida) ou sair para encerrar a aplicação: ");
    entrada = ReadLine();
    
    if (entrada == "entrada")
    {
        Write("Digite o número de turistas: ");
        turistas = int.Parse(ReadLine());
            if (turistas <= 4)
        {
        contagem = contagem + turistas;
        WriteLine($"Entrada de turistas registrada em: {data:dd/MM/yyyy hh:mm}");
        WriteLine($"Número de turistas no parque: {contagem}");  
        }
            else
            {
            WriteLine("Não é possivel registrar esse valor.");
            }
    }
    else if (entrada == "saida")
    {
        Write("Digite o número de turistas: ");
        turistas = int.Parse(ReadLine());
            if (turistas <= contagem)
        {
        contagem = contagem - turistas;
        WriteLine($"Saída de turistas registrada em: {data:dd/MM/yyyy hh:mm}");
        WriteLine($"Número de turistas no parque: {contagem}");
        }   
            else
            {
            WriteLine("Não é possivel registrar esse valor.");
            }
    
    }
    else if (entrada == "sair")
    {
        WriteLine("Encerrando programa.");
        break;
    }
    else if (entrada != "entrada" | entrada != "saida" | entrada != "sair")
    {
        WriteLine("ERRO: Digite um dos comandos citados anteriormente");
    }
}