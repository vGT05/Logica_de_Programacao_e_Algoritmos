using static System.Console;
//Declaração de variaveis
const int SENHAFIXA = 2002;
int senha, contagem = 0;
//Entrada de dados
Write("digite a senha: ");
senha = int.Parse(ReadLine());
//Processamento de dados
while (senha != SENHAFIXA)
{
    if  (contagem >= 3)
    {
        WriteLine("Acesso bloqueado");
        break;
    }
    Write("Senha incorreta, digite novamente: ");
    senha = int.Parse(ReadLine());
    contagem++;
}
if (contagem < 3)
{
    Write("Acesso permitido");
}
else
{
    Write("Número de tentativas excedido, aguarde 30 segundos");
}
