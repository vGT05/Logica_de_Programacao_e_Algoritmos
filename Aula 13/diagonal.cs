using static System.Console;

int n = 0, contagem = 0;

Write("Qual vai ser o tamanho da matriz? (máximo de 10): ");
n = int.Parse(ReadLine());
if (n <= 10 & n > 0)
{
    int[,] matriz = new int [n,n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write($"Digite o valor para a posição [{i},{j}]");
            matriz[i,j] = int.Parse(ReadLine());
        }
    }
    WriteLine("Matriz preenchida.");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write(matriz[i, j] + "\t");
            if (matriz[i,j] < 0){
            contagem++;
            }
        }
        WriteLine();
    }
    Write("Diagonal principal");
    for (int i = 0; i < n; i++)
        {
            WriteLine($"{matriz[i,i]} ");
        }

        WriteLine($"Quantidade de negativos {contagem}");

}
