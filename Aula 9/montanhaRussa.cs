using static System.Console;

int altMin, altMax, vis, alt, total = 0;
try{
Write("Digite a altura mínima: ");
altMin = int.Parse(ReadLine());
Write("Digite a altura máxima: ");
altMax = int.Parse(ReadLine());
Write("Digite o número de visitantes: ");
vis = int.Parse(ReadLine());

for (int i = 0; i < vis; i++)
{
    Write($"Digite a altura da pessoa número {i+1}: ");
    alt = int.Parse(ReadLine());
    total++;
    if (alt <= altMax & alt >= altMin)
    {
        WriteLine($"{total} pessas estão entre {altMin} e {altMax}");
    }
    else
    {
        WriteLine($"{total} não possuem altura permitida");
    }


}


}
catch (Exception ex)
{
    WriteLine("Digite um valor válido.", ex.Message);
}