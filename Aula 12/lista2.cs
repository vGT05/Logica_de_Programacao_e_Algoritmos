using static System.Console;

int n;
List <double> numeros = new List<double>();

Write("Quantos números voce vai digitar? ");
n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    Write("Digite um número: ");
    numeros.Add(double.Parse(ReadLine()));
}

Write("Valores = ");
for (int i = 0; i < n; i++)
{
    Write($" {numeros[i]}");
}
Write($"\nSoma = {numeros.Sum()}");
Write($"\nMédia = {numeros.Average()}");