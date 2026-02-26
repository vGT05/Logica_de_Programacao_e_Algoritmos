using System.Linq.Expressions;
using static System.Console;
//Declaração de Variáveis
double a, b, c, delta, x1, x2;
//Entrada de dados
Write("Digite o valor de A: ");
a = double.Parse(ReadLine());
Write("Digite o valor de B: ");
b = double.Parse(ReadLine());
Write("Digite o valor de C: ");
c = double.Parse(ReadLine());
//processamento de dados
delta = (b*b) - (4*a*c);
//controle de decição e saída de dados
if (delta < 0)
{
    WriteLine("Raízes impossíveis");
}
else if (delta == 0)
{
    x1 = -b/(2*a);
    x2 = x1;
    WriteLine($"X1 = {x1}\nX2 = {x2}");
}
else
{
    x1 = (-b - Math.Sqrt(delta))/(2*a);
    x2 = (-b + Math.Sqrt(delta))/(2*a);
    WriteLine($"X1 = {x1}\nX2 = {x2}");
}


