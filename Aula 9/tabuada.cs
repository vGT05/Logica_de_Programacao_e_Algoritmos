using static System.Console;
//Declaração de variáveis
int numero;
//Entrada de dados
Write("Digite um número: ");
numero = int.Parse(ReadLine());
//Processamento de dados
for (int i = 0; i < 10; i++)
{
    WriteLine($"{numero} X {i+1} = {numero * (i+1)}");
}
