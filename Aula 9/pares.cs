using static System.Console;

int numero, valor;

try
{
    Write("Quantos números voce vai digitar? ");
    numero = int.Parse(ReadLine());
    //------------Processamento
    for (int i=0; i < numero; i++)
    {
        Write("Digite um número: ");
        valor = int.Parse(ReadLine());
        //teste de valores positivos, negativos e nulos
        if (valor < 0)
        {
            Write("Negativo, ");
        }
        else if (valor > 0)
        {
            Write("Positivo, ");
        }
        else
        {
            Write("Nulo, ");
        }
    //teste de parer ou impares
    if ((valor%2) == 0)
        {
            WriteLine("Par");
        }
    else if ((valor % 2) != 0)
        {
            WriteLine("Impar");
        }
    }
}
catch(Exception ex)
{
WriteLine("Valor invalido, erro:", ex.Message);
}