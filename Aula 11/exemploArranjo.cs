using static System.Console;
using static System.Linq.Enumerable;

int n;

Write("Quantos número voce vai digitar? ");
n = int.Parse(ReadLine());
if (n <= 0)
{
    WriteLine("Valor invalido, digite somente números positivos.");
}
else if (n > 10)
{
    WriteLine("Máximo de valores para digitar é 10.");
    WriteLine("Tente novamente");
}   
else
{
    //declaração do vetor
    int [] numeros = new int [n];
    for (int i = 0; i < numeros.Length ; i++)
    {
        Write($"Digite o {i+1}° número: ");
        numeros [i] = int.Parse(ReadLine());
    }

    WriteLine("Numeros negativos: ");
    foreach (int item in Range(0, numeros.Length))
    {
        if (numeros[item] < 0)
        {
            WriteLine(numeros[item]);
        }
    }
}