using static System.Console;

int altMin, altMax, vis, alt, totalpos = 0, totalneg = 0;
//Eu queria usar o static void aqui, mas não consegui fazer funcionar nem a pau
try{
Write("Digite o número de visitantes: ");
vis = int.Parse(ReadLine());
Write("Digite a altura mínima: ");
altMin = int.Parse(ReadLine());
Write("Digite a altura máxima: ");
altMax = int.Parse(ReadLine());

for (int i = 0; i < vis; i++)
{
    Write($"Digite a altura da pessoa número {i+1}: ");
    alt = int.Parse(ReadLine());

    if (alt <= altMax & alt >= altMin)
    {
        totalpos++;
    }
    else
    {
        totalneg++;
    }
}

WriteLine($"{totalpos} pessoas estão entre {altMin} e {altMax}, e {totalneg} não possuem a altura necessária.");

}
catch (Exception ex)
{
    WriteLine("ERRO: o valor digitado não é válido.", ex.Message);
}