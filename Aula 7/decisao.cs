using static System.Console;
//Entrada de dados
WriteLine("Digite o denominador para realizar divisão: ");
double den = double.Parse(ReadLine());
WriteLine("Digite o numerador para realizar a divisão: ");
double num = double.Parse(ReadLine());
double resultado;
//Processamento de dados
if (den > 0 & num > 0)
{
    resultado = den / num;
}
else if (den == 0 | num == 0)
{
    resultado = den - num;
}
else
{
    resultado = den * num;
}
//Saída de dados
WriteLine($"O resultado é {resultado}");