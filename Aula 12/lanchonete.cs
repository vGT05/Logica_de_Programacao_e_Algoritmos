using static System.Console;

int quantidade, produto;
Dictionary <int, double> codigo = new Dictionary<int, double>
{
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5, 7.32},
};

try
{
    Write("Digite o código do produto: ");
    produto = int.Parse(ReadLine());
    Write("Digite a quantidade de produtos: ");
    quantidade = int.Parse(ReadLine());

WriteLine($"Total a pagar: R${codigo[produto] * quantidade:F2}.");
}

catch (Exception)
{
    WriteLine("Digite um código válido.");
}