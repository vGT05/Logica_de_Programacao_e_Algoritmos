using static System.Console;

double n1, n2, nf;

Write("Digite a primeira nota: ");
n1 = double.Parse(ReadLine());
Write("Digite A segunda nota: ");
n2 = double.Parse(ReadLine());

nf = (n1 + n2);

if (nf > 60)
{
    WriteLine($"Sua nota é de {nf:F2}");
    WriteLine("Parabéns!");
}
    else
{
    WriteLine($"Sua nota é {nf:F2}");
    WriteLine("Voce foi REPROVADO");
}
    