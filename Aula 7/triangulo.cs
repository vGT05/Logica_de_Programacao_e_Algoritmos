using static System.Console;

int a, b, c;
double p, areaTrap, areaTri;

Write("Digite o primeiro valor: ");
a = int.Parse(ReadLine());
Write("Digite o segundo valor: ");
b = int.Parse(ReadLine());
Write("Digite o terceiro valor: ");
c = int.Parse(ReadLine());

if ((a+b) < c)
{
    areaTrap = ((a+b)*c)/2;
    WriteLine("Não foi possível formar um triângulo.");
    WriteLine($"A área do trapézio é {areaTrap}");
}
else if ((a+c) < b)
{
    areaTrap = ((a+b)*c)/2;
    WriteLine("Não foi possível formar um triângulo.");
    WriteLine($"A área do trapézio é {areaTrap}");
}
else if ((c+b) < a)
{
    areaTrap = ((a+b)*c)/2;
    WriteLine("Não foi possível formar um triângulo.");
    WriteLine($"A área do trapézio é {areaTrap}");
}
else
{
    p = (a + b + c) / 2;
    areaTri = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    WriteLine($"A área do triângulo é de {areaTri:F}");
}